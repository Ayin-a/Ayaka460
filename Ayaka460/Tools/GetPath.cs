using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayaka460.Tools
{
    internal class GetPath
    {
        public static string GetLauncherPath()
        {
            RegistryKey key = Registry.LocalMachine;       
            string launcherpath = key.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\原神").GetValue("InstallPath").ToString();
            byte[] bytepath = Encoding.UTF8.GetBytes(launcherpath); 
            string path = Encoding.UTF8.GetString(bytepath);
            return path;

        }
    }
}
