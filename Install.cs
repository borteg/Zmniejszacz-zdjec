using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using Microsoft.Win32;

namespace Zmniejszacz_zdjęć
{
    class Install
    {
        private const string softwarePath = "SOFTWARE";
        private const string authorSubKey = "Bartosz Majdan";
        private const string appNameSubKey = "Zmniejszacz zdjęć";
        private const string mainSubKey = authorSubKey + "\\" + appNameSubKey;
        private const string mainSubKeyPath = softwarePath + "\\" + mainSubKey;
        private const string shellJpgPath = "SystemFileAssociations\\.jpg\\shell";
        private const string shellJpegPath = "SystemFileAssociations\\.jpeg\\shell";
        private const string contextMenuItemName = "Zmniejsz";
        private const string shellJpgFullPath = shellJpgPath + "\\" + contextMenuItemName + "\\command";
        private const string shellJpegFullPath = shellJpegPath + "\\" + contextMenuItemName + "\\command";

        private static string versionKey = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private static string currentAppPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        private static string shellAppPath = "\"" + currentAppPath + "\"" + " " + "\"%1\"";

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

        public static void Installation()
        {
            RegistryKey subKey = Registry.LocalMachine.CreateSubKey(mainSubKeyPath); ;

            subKey.SetValue("version", versionKey);
            subKey.SetValue("path", currentAppPath);

            subKey = Registry.ClassesRoot.CreateSubKey(shellJpgFullPath);
            subKey.SetValue(null, shellAppPath);

            subKey = Registry.ClassesRoot.CreateSubKey(shellJpegFullPath);
            subKey.SetValue(null, shellAppPath);
        }

        public static void Remove()
        {
            RegistryKey subKey = Registry.LocalMachine.OpenSubKey(softwarePath, true);

            subKey.DeleteSubKeyTree(authorSubKey);

            subKey = Registry.ClassesRoot.OpenSubKey(shellJpgPath, true);
            subKey.DeleteSubKeyTree(contextMenuItemName);

            subKey = Registry.ClassesRoot.OpenSubKey(shellJpegPath, true);
            subKey.DeleteSubKeyTree(contextMenuItemName);
        }
    }
}
