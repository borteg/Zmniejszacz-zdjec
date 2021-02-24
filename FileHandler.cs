using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private static ObservableCollection<string> files = new ObservableCollection<string>();

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

        public static ObservableCollection<string> ReadFiles()
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
                    MessageBox.Show("Ten plik znajduje się już na liście: " + file1, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }

            return true;
        }
    }
}
