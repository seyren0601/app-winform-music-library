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

        public void RecurseFolders(string path, TreeNode node)
        {
            var dir = new DirectoryInfo(path);
            node.Text = dir.Name;

            try
            {
                foreach(var subdir in dir.GetDirectories())
                {
                    var childNode = new TreeNode();
                    node.Nodes.Add(childNode);

                    RecurseFolders(subdir.FullName, childNode);
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Unauthorized at folder. Mesasge: {ex.Message}");
            }

            foreach(var fileInfo in dir.GetFiles().OrderBy(c => c.Name))
            {
                var fileNode = new TreeNode(fileInfo.Name);
                fileNode.Tag = fileInfo.FullName;
                node.Nodes.Add(fileNode);
            }
        }
    }
}
