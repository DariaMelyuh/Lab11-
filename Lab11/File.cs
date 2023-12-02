﻿namespace Lab11
{
    public class File : IFile
    {
        private string _filePath;

        public File(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            _filePath = path;
        }

        public double GetSize()
        {
            var file = new FileInfo(_filePath);
            return file.Length;
        }

        public string GetPath()
        {
            return _filePath;
        }

        public byte[] Show()
        {
            return System.IO.File.ReadAllBytes(_filePath);
        }
    }

}
