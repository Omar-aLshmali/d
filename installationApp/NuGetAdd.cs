using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installationApp
{
	class NuGetAdd
	{
		public void SetNuGet(string filePath)
		{
			if (File.Exists(filePath + "\\nuget.exe") == false)
			{
				Directory.CreateDirectory(filePath);
				using (var client = new WebClient())
				{
					client.DownloadFile("https://dist.nuget.org/win-x86-commandline/latest/nuget.exe", filePath + "\\nuget.exe");
				}
			}
		}

		public void GetNuGet()
		{
				if (File.Exists(@"C:\ProgramFiles\NuGet" + "\\nuget.exe") == false)
				{
					SetNuGet(@"C:\ProgramFiles\NuGet");
					MessageBox.Show("NuGet wurde hinzugefügt");
				}
				else
				{
					MessageBox.Show("NuGet ist schon Vorhanden");
				}
		}

	}
}