using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class File : IFile
    {
        private string filePath;
        private byte[] fileData;

        public File(string path)
        {
            filePath = path;
            FileData();
        }

        private void FileData()
        {
            fileData = System.IO.File.ReadAllBytes(filePath);
        }

        public double GetSize()
        {
            return fileData.Length;
        }

        public string GetPath()
        {
            return filePath;
        }

        public byte[] Show()
        {
            return fileData;
        }

        public void Dispose()
        {
          
        }
    }
}
