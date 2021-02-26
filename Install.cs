using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;

namespace Zmniejszacz_zdjęć
{
    class Install
    {
        private const string softwarePath = "SOFTWARE";
        private const string author = "Bartosz Majdan";
        private const string appName = "Zmniejszacz zdjęć";
        private const string mainSubKey = author + "\\" + appName;
        private const string mainSubKeyPath = softwarePath + "\\" + mainSubKey;
        private const string shellJpgPath = "SystemFileAssociations\\.jpg\\shell";
        private const string shellJpegPath = "SystemFileAssociations\\.jpeg\\shell";
        private const string contextMenuItemName = "Zmniejsz";
        private const string shellCommandJpgPath = shellJpgPath + "\\" + contextMenuItemName + "\\command";
        private const string shellCommandJpegPath = shellJpegPath + "\\" + contextMenuItemName + "\\command";
        private const string shellIconJpgPath = shellJpgPath + "\\" + contextMenuItemName;
        private const string shellIconJpegPath = shellJpegPath + "\\" + contextMenuItemName;

        private static string versionKey = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private static string currentAppPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string installationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), author, appName, appName + ".exe");
        private static string shellAppPath = "\"" + installationPath + "\"" + " " + "\"%1\"";
        private static string shellIconPath = "\"" + installationPath + "\"";

        public static bool IsAdmin()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool IsInstall()
        {
            if (Registry.LocalMachine.OpenSubKey(mainSubKeyPath) != null)
            {
                return true;
            }

            return false;
        }
        public static bool Installation()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(installationPath));

                System.IO.File.Copy(currentAppPath, installationPath, true);

                WshShell shell = new WshShell();
                string shortcutAddress = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetFileNameWithoutExtension(installationPath)) + ".lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.TargetPath = installationPath;
                shortcut.Save();

                RegistryKey subKey;

                subKey = Registry.ClassesRoot.CreateSubKey(shellCommandJpgPath);
                subKey.SetValue(null, shellAppPath);

                subKey = Registry.ClassesRoot.CreateSubKey(shellCommandJpegPath);
                subKey.SetValue(null, shellAppPath);

                subKey = Registry.ClassesRoot.OpenSubKey(shellIconJpgPath, true);
                subKey.SetValue("Icon", shellIconPath);

                subKey = Registry.ClassesRoot.OpenSubKey(shellIconJpegPath, true);
                subKey.SetValue("Icon", shellIconPath);

                subKey = Registry.LocalMachine.CreateSubKey(mainSubKeyPath);

                subKey.SetValue("version", versionKey);
                subKey.SetValue("path", installationPath);
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool Remove()
        {
            if(Path.GetDirectoryName(currentAppPath) == Path.GetDirectoryName(installationPath))
            {
                MessageBox.Show("Plik wykonywalny znajduje się w folderze, który zostanie usunięty podczas deinstalacji. \nUtwórz kopię pliku wykonywalnego w innym miejscu i uruchom w nim proces deinstalacji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            try
            {
                if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), author)))
                {
                    Directory.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), author), true);
                }

                if(System.IO.File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetFileNameWithoutExtension(installationPath)) + ".lnk"))
                {
                    System.IO.File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetFileNameWithoutExtension(installationPath)) + ".lnk");
                }

                RegistryKey subKey;

                if (Registry.ClassesRoot.OpenSubKey(shellCommandJpgPath, true) != null)
                {
                    subKey = Registry.ClassesRoot.OpenSubKey(shellJpgPath, true);
                    subKey.DeleteSubKeyTree(contextMenuItemName);
                }

                if (Registry.ClassesRoot.OpenSubKey(shellCommandJpegPath, true) != null)
                {
                    subKey = Registry.ClassesRoot.OpenSubKey(shellJpegPath, true);
                    subKey.DeleteSubKeyTree(contextMenuItemName);
                }

                if (Registry.LocalMachine.OpenSubKey(mainSubKeyPath, true) != null)
                {
                    subKey = Registry.LocalMachine.OpenSubKey(softwarePath, true);
                    subKey.DeleteSubKeyTree(author);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
