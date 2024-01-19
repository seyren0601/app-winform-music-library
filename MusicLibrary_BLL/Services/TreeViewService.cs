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

        public void AddFile(string path, TreeView tree)
        {
            var fileInfo = new FileInfo(path);
            var fileNode = new TreeNode(fileInfo.Name);
            fileNode.Tag = new MusicFile(fileInfo);
            fileNode.SelectedImageIndex = fileNode.ImageIndex = 1;
            tree.Nodes.Add(fileNode);
        }

        public List<TreeNode> GetAllNodes(TreeNode node)
        {
            List<TreeNode> result = new List<TreeNode>();
            result.Add(node);
            foreach(TreeNode child in node.Nodes)
            {
                result.AddRange(GetAllNodes(child));
            }
            return result;
        }

        public void AddFolderToPlaylist(TreeNode node, MusicList playlist)
        {
            foreach(TreeNode sub_node in node.Nodes)
            {
                if (sub_node.Tag is DirectoryInfo) AddFolderToPlaylist(sub_node, playlist);
                else playlist.Add(sub_node.Tag as MusicFile);
            }
        }
    }
}
