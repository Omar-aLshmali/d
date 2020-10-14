using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installationApp
{
	public partial class Form1 : Form
	{
		readonly CheckInstall check = new CheckInstall();
        ChocolateyInstall chocolateyInstall = new ChocolateyInstall();
        EnvironmentVariables environmentVariables = new EnvironmentVariables();
        NuGetAdd nuGet = new NuGetAdd();
        public Form1()
		{
			InitializeComponent();
		
		}
        private void Form1_Load(object sender, EventArgs e)
		{
			ToInstalItemAdd();
			IsInstalledView();
			foreach (var i in InstalledPrograms.GetInstalledPrograms())
            {
				allProgramsList.Items.Add(i);
			}
		}
		/// <summary>
		///  This method packs the result of installed and uninstalled programs into a list.
		/// </summary>
		private void IsInstalledView()
		{
			List<string> apps = ToControlList(); // Content of the ToControlList method in apps list
			for (int i = 0; i < apps.Count; i++) 
			{
				// Using the CheckInstalled method, all programs are checked by name to see if they are installed.
				if (check.CheckInstalled(apps[i])) // If the method returns true, then Program is inatall.
				{
					checkList.Items.Add(apps[i] + " ist installiert"); 
				}
				else 
				{
					if (apps[i].Equals("NuGet"))
					{
						if (File.Exists(@"C:\ProgramFiles\NuGet" + "\\nuget.exe") == false) //is checked, if a folder of "NuGet" already exists
						{
							checkList.Items.Add(apps[i] + " ist nicht vorhanden");
							checkList.Items[i].ForeColor = Color.Red;
						}
						else 
						{
							checkList.Items.Add(apps[i] + " ist vorhanden");
						}
					}
					else
					{
						checkList.Items.Add(apps[i] + " ist nicht installiert");
						checkList.Items[i].ForeColor = Color.Red;
					}
				}}}
		/// <summary>
		/// List of program names, with possibility to install them if they are not already installed. 
		/// </summary>
		private void ToInstalItemAdd()
		{
			toInstall.Items.Add("Install Visual Studio");
			toInstall.Items.Add("Install Visual Studio üder Chocolaty");
			toInstall.Items.Add("Install Git");
			toInstall.Items.Add("NuGet hinfügen");
			toInstall.Items.Add("Umgebungsveriable hinfügen");
			toInstall.Items.Add("install Notepad++");
			toInstall.Items.Add("Install 7-Zip");
		}
		/// <summary>
		/// List of programs that need to be checked.
		/// </summary>
		/// <returns>Contents of the list</returns>
		private static List<string> ToControlList()
		{
			return new List<string>
			{
				"Visual Studio",
				"Git version",
				"7-Zip",
				"Notepad++ ",
				"NuGet"
			};
		}
		/// <summary>
		/// dieser Butten ist mit toinstal-list verbunden, beim drücken wird die ausgewählte Option installiert.
		/// </summary>
        private void BtnInstal_Click(object sender, EventArgs e)
        {
            int index = toInstall.SelectedIndex;
        switch (index)
		{
				case 0:
					{
						Process.Start(@"\\installsrv01\Install\Microsoft\Visual Studio Professional 2019\vs_professional__1538188582.1568269268.exe");
						break;
					}
				case 1:
					{chocolateyInstall.InstallVisualStudio(); break;}
				case 2:
					{ chocolateyInstall.InstallGit();         break;}
				case 3:
					{ nuGet.GetNuGet();                       break;}
				case 4:
					{ AddEnvironmentalVariables();            break;}
				case 5:
					{ chocolateyInstall.InstallNotepad();     break;}
				case 6:
					{ chocolateyInstall.Install_7_Zip();      break;}
			}
        }
        private void AddEnvironmentalVariables()
        {
			environmentVariables.SetEnvironment(";C:\\ProgramFiles\\NuGet;", "NuGet", "NuGet");
            environmentVariables.SetEnvironment(";C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Professional\\MSBuild\\Current\\Bin;", "MSBuild\\Current\\Bin", "MSBuild");
         }

		private void Refresh_Button1_Click(object sender, EventArgs e)
		{
			checkList.Items.Clear();
			toInstall.Items.Clear();
			allProgramsList.Items.Clear();
			Form1_Load(sender, e);
		}
	}
}