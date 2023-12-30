using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary_BLL.Services
{
    public class TreeViewService
    {
        static TreeViewService? Instance = null;
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
                                        .Where(c=>c.Extension == ".mp3")
                                        .OrderBy(c => c.Name))
            {
                var fileNode = new TreeNode(fileInfo.Name);
                fileNode.Tag = fileInfo.FullName;
                fileNode.SelectedImageIndex = fileNode.ImageIndex = 1;
                folderNode.Nodes.Add(fileNode);
            }
        }
    }
}
