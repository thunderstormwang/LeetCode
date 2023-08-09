namespace LeetCode.Solution0501_0700;

public class Solution0588
{
    public class FileSystem_Ver1
    {
        private class File
        {
            public bool IsFile { get; set; }
            public string Content { get; set; }
            public Dictionary<string, File> Children { get; set; }

            public File()
            {
                IsFile = false;
                Content = string.Empty;
                Children = new Dictionary<string, File>();
            }
        }

        private File _root;

        public FileSystem_Ver1()
        {
            _root = new File();
        }

        public IList<string> Ls(string path)
        {
            var node = GetNode(path);
            if (node.IsFile)
            {
                return new List<string> { GetFileName(path) };
            }

            var result = new List<string>(node.Children.Keys);
            result.Sort();
            return result;
        }

        public void Mkdir(string path)
        {
            var node = GetNode(path, createMissing: true);
        }

        public void AddContentToFile(string filePath, string content)
        {
            var node = GetNode(filePath, createMissing: true);
            node.IsFile = true;
            node.Content += content;
        }

        public string ReadContentFromFile(string filePath)
        {
            var node = GetNode(filePath);
            return node.Content;
        }

        private File GetNode(string path, bool createMissing = false)
        {
            var parts = path.Split('/');
            var node = _root;

            foreach (var part in parts)
            {
                if (string.IsNullOrEmpty(part))
                {
                    continue;
                }

                if (!node.Children.ContainsKey(part))
                {
                    if (createMissing)
                    {
                        node.Children[part] = new File();
                    }
                    else
                    {
                        throw new Exception("Path not found");
                    }
                }

                node = node.Children[part];
            }

            return node;
        }

        private string GetFileName(string path)
        {
            var parts = path.Split('/');
            return parts[parts.Length - 1];
        }
    }
}