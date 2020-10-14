using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installationApp
{
	class ChocolateyInstall
	{
		readonly CheckInstall check = new CheckInstall();
		public void PowerShellCommands(string command)
		{
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Verb = "runas",
				Arguments = command
			};
			process.StartInfo = startInfo;
			process.Start();
		}
		private void ChocoComand(string cmdInstall)
		{
			PowerShellCommands("/c" + @"%SystemRoot%\System32\WindowsPowerShell\v1.0\powershell.exe -NoProfile -InputFormat None -ExecutionPolicy Bypass -Command iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1')) && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin");
			MessageBox.Show("Please close this window if the cmd close!");
			PowerShellCommands("/c" + cmdInstall);
			MessageBox.Show("Please write Y in the console always! Please close this window if the cmd close!");
		}
		public void InstallNotepad()
		{
			if (check.CheckInstalled("Notepad++"))
				{ MessageBox.Show("Notepad++ ist Vorhanden"); }
			else
				{
					ChocoComand("choco install notepadplusplus");
				}
		}
		public void InstallGit()
		{
			if (check.CheckInstalled("Git version"))
				{ MessageBox.Show("Git ist Vorhanden"); }
			else
				{
					ChocoComand("choco install git");
				}
		}
		public void InstallVisualStudio()
		{      
			if (check.CheckInstalled("Visual Studio"))
				{ MessageBox.Show("Visua Studio ist schon installiert"); }
			else
				{
					ChocoComand("choco install visualstudio2019community");
				}
			
		}
		public void Install_7_Zip()
		{
			if (check.CheckInstalled("7-Zip"))
				{ MessageBox.Show("7-Zip ist Vorhanden"); }
			else
				{
					ChocoComand("choco install 7zip.install");
				}
		}
    }
}
