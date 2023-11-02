using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class FileProxy : IFile
    {
        private string filePath;
        private File file;

        public FileProxy(string path)
        {
            filePath = path;
        }

        public double GetSize()
        {
            CreateFile();
            return file.GetSize();
        }

        public string GetPath()
        {
            CreateFile();
            return file.GetPath();
        }

        public byte[] Show()
        {
            CreateFile();
            return file.Show();
        }

        private void CreateFile()
        {
            file = new File(filePath);
        }

        public void Dispose()
        {
          file.Dispose();
        }
    }
}
