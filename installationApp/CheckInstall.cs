using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace installationApp
{
	class CheckInstall
	{
        public  bool CheckInstalled(string c_name)
        {
			string displayName;

			string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

			using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(registryKey))
			{
				if (key != null)
				{
					foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
					{
						displayName = subkey.GetValue("DisplayName") as string;
						if (displayName != null && displayName.Contains(c_name))
						{
							return true;
						}
					}
					key.Close();
				}
			}

			return false;
        }
    }
}
