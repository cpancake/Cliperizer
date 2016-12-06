using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliperizer
{
	public static class RecentManager
	{
		public static string DataDir => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Cliperizer");
		public static string RecentFile => Path.Combine(DataDir, "recent");

		public static void WriteRecent(IEnumerable<string> files)
		{
			CreateDataDirectory();
			using(var stream = File.OpenWrite(RecentFile))
			{
				using(var writer = new StreamWriter(stream))
				{
					foreach(var file in files)
					{
						writer.WriteLine(file);
					}
				}
			}
		}

		public static void ClearItems()
		{
			CreateDataDirectory();
			File.Delete(RecentFile);
		}

		public static IEnumerable<string> ReadRecent()
		{
			CreateDataDirectory();
			if(!File.Exists(RecentFile))
			{
				yield break;
			}

			using(var stream = File.OpenRead(RecentFile))
			{
				using(var reader = new StreamReader(stream))
				{
					while(!reader.EndOfStream)
					{
						yield return reader.ReadLine();
					}
				}
			}
		}

		private static void CreateDataDirectory()
		{
			if(!Directory.Exists(DataDir))
			{
				Directory.CreateDirectory(DataDir);
			}
		}
	}
}
