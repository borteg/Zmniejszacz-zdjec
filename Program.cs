using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Zmniejszacz_zdjęć
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool noGui = false;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(args != null)
            {
                foreach(string arg in args)
                {
                    if(arg.Equals("--nogui"))
                    {
                        noGui = true;
                    }

                    else
                    {
                        if(ImageHandler.isJpeg(arg))
                        {
                            FileHandler.AddFile(arg);
                        }
                    }
                }
            }

            if (!noGui)
            {
                Application.Run(new FormMain());
            }

            else
            {
                foreach (string path in FileHandler.ReadFiles())
                {
                    if(ImageHandler.Resize(path))
                    {
                        ImageHandler.Save(path);
                    }
                }

                MessageBox.Show("Zmniejszono pomyślnie");
            }
        }
    }
}
