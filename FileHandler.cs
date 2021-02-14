using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Zmniejszacz_zdjęć
{
    class FileHandler
    {
        private static List<string> files = new List<string>();

        public static void AddFiles(string[] newFiles)
        {
            foreach(string file in newFiles)
            {
                files.Add(file);
            }
        }
        public static void AddFile(string newFile)
        {
            files.Add(newFile);
        }

        public static List<string> ReadFiles()
        {
            return files;
        }

        public static void ClearFiles()
        {
            files.Clear();
        }

        public static void RemoveFile(int nFile)
        {
            files.RemoveAt(nFile);
        }

        public static bool NotDuplicate(string file1)
        {
            foreach(string file2 in files)
            {
                if(file1.Equals(file2))
                {
                    MessageBox.Show("Ten plik znajduje się już na liście: " + file1);

                    return false;
                }
            }

            return true;
        }
    }
}
