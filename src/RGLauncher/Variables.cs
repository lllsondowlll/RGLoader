using System;
using System.IO;
using System.Windows.Forms;

namespace RGBuilder_Launcher_Csharp
{
	internal class Variables
	{
		public static string LocalPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\";

		public static string CPUkey;

		public static string NandPath;
	}
}
