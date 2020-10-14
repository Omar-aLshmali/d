using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installationApp
{
	class EnvironmentVariables
	{ 
public void SetEnvironment(string addFile, string search,string variable)
	{
		string text = GetEnvironment(search);
		if ("" != text)
		{
			Environment.SetEnvironmentVariable("Path", text + addFile, EnvironmentVariableTarget.User);
			MessageBox.Show(variable + " wird hinzugefügt!");
		}
		else
			{
				MessageBox.Show(variable+" ist schon vorhanden!");
			}
	}

	public string GetEnvironment(string search)
	{
		var environmentVariable = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
		string text = "";
		foreach (DictionaryEntry de in environmentVariable)
		{
			if (de.Key.ToString() == "Path")
			{
				string[] texte = de.Value.ToString().Split(';');
				for (int i = 0; i < texte.Length; i++)
				{
					if (texte[i].Contains(search) == true) 
					{
						return "";
					}
					text = de.Value.ToString();
				}
			}
		}
		return text;
	}

}
}
