using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayaka460.Tools
{
    internal class GetGenshinRegistryLocation
    {
        public string GetRegistryLocation()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\原神");
            if (key != null)
            {
                // 获取注册表项的值
                string installPath = key.GetValue("InstallPath").ToString();
                MessageBox.Show(installPath);
                return installPath;
            }
            return null;
        }
    }
}
