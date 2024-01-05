using MusicLibrary_BLL.Models;
using MusicLibrary_DAL.Entities;
using MetaBrainz.MusicBrainz;
using TagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using NAudio.Wave;
using ZstdSharp.Unsafe;

namespace MusicLibrary_BLL.Services
{
    public class TreeViewService
    {
        static TreeViewService? Instance = null;
        MusicBrainz _musicBrainz = MusicBrainz.GetInstance();
        public static TreeViewService GetInstance()
        {
            if(Instance == null) return Instance = new TreeViewService();
            else return Instance;
        }
        public void BindDirectoryToTreeView(TreeView directoryTree, string rootPath)
        {
            TreeNode rootNode = new TreeNode();
            directoryTree.Nodes.Add(rootNode);
            RecurseFolders(rootPath, rootNode);
        }

        public void RecurseFolders(string path, TreeNode folderNode)
        {
            var dir = new DirectoryInfo(path);
            folderNode.Text = dir.Name;
            folderNode.Tag = dir;
            folderNode.SelectedImageIndex =  folderNode.ImageIndex = 0;

            try
            {
                foreach(var subdir in dir.GetDirectories())
                {
                    var childNode = new TreeNode();
                    folderNode.Nodes.Add(childNode);

                    RecurseFolders(subdir.FullName, childNode);
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Unauthorized at folder. Mesasge: {ex.Message}");
            }

            foreach(var fileInfo in dir.GetFiles()
                                        .Where(c=>c.Extension == ".mp3" || c.Extension == ".flac")
                                        .OrderBy(c => c.Name))
            {
                var fileNode = new TreeNode(fileInfo.Name);
                fileNode.Tag = new MusicFile(fileInfo);
                fileNode.SelectedImageIndex = fileNode.ImageIndex = 1;
                folderNode.Nodes.Add(fileNode);
            }
        }

        public void AddFolderToPlaylist(TreeNode node, MusicList playlist)
        {
            foreach(TreeNode sub_node in node.Nodes)
            {
                if (sub_node.Tag is DirectoryInfo) AddFolderToPlaylist(sub_node, playlist);
                else playlist.Add(sub_node.Tag as MusicFile);
            }
        }

        public async Task<List<dbo_MusicFile>> AddAlbum(string filePath, string root, dbo_Artist Artist, dbo_Album Album)
        {
            string AlbumDirectoryPath = root + $"\\{Artist.ArtistName}\\{Album.Title}";
            DirectoryInfo directoryInfo = new DirectoryInfo(root + $"\\{Artist.ArtistName}");
            Directory.CreateDirectory(AlbumDirectoryPath);

            List<dbo_MusicFile> Add_Files = new List<dbo_MusicFile>();

            foreach(string oldPath in Directory.GetFiles(filePath))
            {
                FileInfo f = new FileInfo(oldPath);
                if (f.Extension == ".mp3")
                {
                    string newPath = oldPath.Replace(filePath, AlbumDirectoryPath);
                    System.IO.File.Copy(oldPath, newPath, true);
                    string songName = Path.GetFileNameWithoutExtension(newPath);
                    using (var q = new Query())
                    {
                        var item_found = await _musicBrainz.FindRecording(Artist, Album, songName);
                        if (item_found != null)
                        {
                            try
                            {
                                item_found.FilePath = newPath;
                                Add_Files.Add(item_found);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Sync failed with file {songName}, {ex.Message}");
                            }
                        }
                        else
                        {
                            TagLib.File file = TagLib.File.Create(newPath);
                            songName = file.Tag.Title;
                            item_found = await _musicBrainz.FindRecording(Artist, Album, songName);
                            if (item_found != null)
                            {
                                try
                                {
                                    item_found.FilePath = newPath;
                                    Add_Files.Add(item_found);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Sync failed with file {songName}, {ex.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"File not found: {songName}");
                            }
                        }
                    }
                }

            }
            return Add_Files;
        }
    }
}
