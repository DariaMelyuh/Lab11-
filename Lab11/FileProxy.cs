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
            if (file != null)
            {
                return file.GetSize();
            }
            else
            {
                return 0; 
            }
        }

        public string GetPath()
        {
            CreateFile();
            if (file != null)
            {
                return file.GetPath();
            }
            else
            {
                return null;
            }
        }

        public byte[] Show()
        {
            CreateFile();
            return file.Show();
        }

        private void CreateFile()
        {
            if (file == null)
            {
                file = new File(filePath);
            }
        }

    }
}
