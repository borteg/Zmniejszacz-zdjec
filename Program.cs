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
                FileHandler.AddFiles(args);

                foreach(string arg in FileHandler.ReadFiles())
                {
                    if (arg.Equals("--nogui"))
                    {
                        noGui = true;
                    }

                    else
                    {
                        Bitmap img = ImageHandler.Resize(arg);

                        ImageHandler.Save(img, arg);
                    }
                }
            }

            if (!noGui)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
