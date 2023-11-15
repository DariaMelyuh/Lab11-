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
            if (!System.IO.File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            filePath = path;
            FileData();
        }

        private void FileData()
        {
            fileData = System.IO.File.ReadAllBytes(filePath);
        }

        public double GetSize()
        {
            if (fileData != null)
            {
                return fileData.Length;
            }
            else
            {
                return 0;
            }

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
            if (fileData != null)
            {
                Array.Clear(fileData, 0, fileData.Length);
                fileData = null;
            }
        }
    }

}
