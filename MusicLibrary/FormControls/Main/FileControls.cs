using MusicLibrary_DAL.Entities;
using MetaBrainz.MusicBrainz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public partial class Main
    {
        public class FileOperationEventArgs : EventArgs
        {
            public readonly int progress;
            public FileOperationEventArgs(int progress)
            {
                this.progress = progress;
            }
        }
        public delegate void FileOperationEventHandler(object o, FileOperationEventArgs e);
        public event FileOperationEventHandler SongAddSuccessfulEvent;
        public async Task<List<dbo_MusicFile>> AddAlbum(string filePath, string root, dbo_Artist Artist, dbo_Album Album)
        {
            string AlbumDirectoryPath = root + $"\\{Artist.ArtistName}\\{Album.Title}";
            DirectoryInfo directoryInfo = new DirectoryInfo(root + $"\\{Artist.ArtistName}");
            Directory.CreateDirectory(AlbumDirectoryPath);
            var oldFiles = Directory.GetFiles(filePath);
            var fileNum = oldFiles.Count(x => x.Contains(".mp3")); // Count number of .mp3 file that will be add
            int progress = 0;

            List<dbo_MusicFile> Add_Files = new List<dbo_MusicFile>();

            foreach (string oldPath in oldFiles)
            {
                FileInfo f = new FileInfo(oldPath);
                if (f.Extension == ".mp3")
                {
                    string newPath = oldPath.Replace(filePath, AlbumDirectoryPath);
                    string songName = Path.GetFileNameWithoutExtension(newPath);
                    // Using file name to query
                    var item_found = await _musicBrainz.FindRecording(Artist, Album, songName);
                    if (item_found != null)
                    {
                        try
                        {
                            item_found.Title = string.Join("", item_found.Title.Split(Path.GetInvalidFileNameChars()));
                            newPath = newPath.Replace(songName, item_found.TrackOffset.ToString("D2") + " " + item_found.Title);
                            item_found.FilePath = newPath;
                            Add_Files.Add(item_found);

                            // Copy file to app's library destination if a match is found
                            System.IO.File.Copy(oldPath, newPath, true);
                            TagLib.File file = TagLib.File.Create(newPath);
                            file.Tag.Track = (uint)item_found.TrackOffset;
                            file.Tag.MusicBrainzTrackId = item_found.SongID;
                            file.Tag.MusicBrainzReleaseArtistId = item_found.ArtistID;
                            file.Save();
                            SongAddSuccessfulEvent.Invoke(this, new FileOperationEventArgs((int)(++progress/(double)fileNum * 100)));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Sync failed with file {songName}, {ex.Message}");
                        }
                    }
                    else
                    {
                        // Using file title property to query
                        TagLib.File file = TagLib.File.Create(oldPath); 
                        songName = file.Tag.Title;
                        item_found = await _musicBrainz.FindRecording(Artist, Album, songName);
                        if (item_found != null)
                        {
                            try
                            {
                                item_found.Title = string.Join("", item_found.Title.Split(Path.GetInvalidFileNameChars()));
                                newPath = newPath.Replace(songName, item_found.TrackOffset.ToString("D2") + " " + item_found.Title);
                                item_found.FilePath = newPath;
                                Add_Files.Add(item_found);

                                // Copy file to app's library destination if a match is found
                                System.IO.File.Copy(oldPath, newPath, true);
                                file = TagLib.File.Create(newPath);
                                file.Tag.Track = (uint)item_found.TrackOffset;
                                file.Tag.MusicBrainzTrackId = item_found.SongID;
                                file.Tag.MusicBrainzReleaseArtistId = item_found.ArtistID;
                                file.Save();
                                SongAddSuccessfulEvent.Invoke(this, new FileOperationEventArgs((int)(++progress / (double)fileNum * 100)));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Sync failed with file {songName}, {ex.Message}");
                            }
                        }
                        else 
                        // If can't find both file name and title,
                        // abort copying to new directory and adding to database
                        {
                            Console.WriteLine($"File not found: {songName}");
                        }
                    }
                }
            }
            return Add_Files;
        }
    }
}
