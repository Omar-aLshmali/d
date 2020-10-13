using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installationApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            
		}

        public static bool CheckInstalled(string c_name)
        {
            string displayName;
         
            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(registryKey);
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
            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
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

            return false;
        }

        private void Button1_Click(object sender, EventArgs e)
		{
            if (CheckInstalled(textBox1.Text))
			{
                result.Text = "ist installiert";
			}
			else
			{
                result.Text = "ist nicht installiert";
			}
          }
        private void Form1_Load(object sender, EventArgs e)
        {
            toInstall.Items.Add("Install Visual Studio");
            toInstall.Items.Add("Install Git");
            toInstall.Items.Add("Install 7-Zip");
            List<string> apps = new List<string>
			{
				"Visual Studio",
				"Git version",
				"7-Zip",
				"fff"
			};
			for (int i = 0; i < apps.Count; i++)
            { 
            if (CheckInstalled(apps[i]))
            {
                checkList.Items.Add(apps[i]+" ist installiert");
            }

            else
            {
                checkList.Items.Add(apps[i]+" ist nicht installiert");
                    checkList.Items[i].ForeColor = Color.Red;
            }
        }
            
            foreach (var i in InstalledPrograms.GetInstalledPrograms())

			{
                listBox1.Items.Add(i);
			}
		}

		private void BtnInstal_Click(object sender, EventArgs e)
		{
            

            int index = toInstall.SelectedIndex;
            label2.Text = index.ToString();
            
                if (index == 0)
                {
                    Process.Start(@"\\installsrv01\Install\Microsoft\Visual Studio Professional 2019\vs_professional__1538188582.1568269268.exe");
                }
            else
			{
                MessageBox.Show("Installaltion ist noch nicht vorhanden");
			}
			
				
		}


	}
}
