using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Cliperizer
{
	public static class FFmpeg
	{
		private const string FFMPEG_NAME = "ffmpeg";

		private static string[] _executableExtensions = { "exe", "bat", "cmd" };
		private static Regex _configRegex = new Regex(@"--enable-([^\s]+)");

		public static void RenderClip(string filename, string outFile, string codecArgs, bool audio, string quality, TimeSpan start, TimeSpan end)
		{
			var audioArg = audio ? "" : "-an";
			var length = (end - start).TotalSeconds;
			var args = $"-ss {start.ToString(@"hh\:mm\:ss")} -i \"{filename}\" {codecArgs} {quality} {audioArg} -t {length} \"{outFile}\"";

			var process = new Process()
			{
				StartInfo = new ProcessStartInfo()
				{
					FileName = FindExecutablePath(),
					Arguments = args,
					WindowStyle = ProcessWindowStyle.Minimized
				}
			};

			process.Start();
			process.WaitForExit();
		}

		public static void ConcatClips(string[] filenames, string outputName)
		{
			var file = Path.GetTempFileName();
			File.WriteAllLines(file, filenames.Select(f => $"file '{f}'"));

			var args = $"-f concat -safe 0 -i \"{file}\" -c copy \"{outputName}\"";

			var process = new Process()
			{
				StartInfo = new ProcessStartInfo()
				{
					FileName = FindExecutablePath(),
					Arguments = args,
					WindowStyle = ProcessWindowStyle.Minimized
				}
			};

			process.Start();
		}

		public static string[] ListSupportedFormats()
		{
			var str = LaunchWithArguments("-version");
			var lines = str.Split('\n');
			var configOptions = _configRegex.Matches(lines[2]);
			return configOptions.Cast<Match>().Select(m => m.Groups[1].Value).ToArray();
		}

		public static bool CheckIfInstalled()
		{
			return FindExecutablePath() != null;
		}

		private static string LaunchWithArguments(string arg)
		{
			var process = new Process()
			{
				StartInfo = new ProcessStartInfo()
				{
					FileName = FindExecutablePath(),
					Arguments = arg,
					CreateNoWindow = true,
					UseShellExecute = false,
					RedirectStandardError = true,
					RedirectStandardOutput = true
				}
			};
			process.Start();
			process.WaitForExit();
			var err = process.StandardError.ReadToEnd();
			if(err.Length > 0)
			{
				throw new Exception(err.Trim());
			}
			return process.StandardOutput.ReadToEnd();
		}

		private static string FindExecutablePath()
		{
			if(ExistsWithExtensions(FFMPEG_NAME, _executableExtensions))
			{
				return Path.GetFullPath(FindWithExtensions(FFMPEG_NAME, _executableExtensions));
			}

			var pathValue = Environment.GetEnvironmentVariable("PATH");
			foreach(var path in pathValue.Split(';'))
			{
				var fullPath = Path.Combine(path, FFMPEG_NAME);
				if(ExistsWithExtensions(fullPath, _executableExtensions))
				{
					return FindWithExtensions(fullPath, _executableExtensions);
				}
			}

			return null;
		}

		public static bool ExistsWithExtensions(string name, string[] extensions)
		{
			return FindWithExtensions(name, extensions) != null;
		}

		public static string FindWithExtensions(string name, string[] extensions)
		{
			foreach(var ext in extensions)
			{
				if(File.Exists(name + "." + ext))
				{
					return name + "." + ext;
				}
			}

			return null;
		}
	}
}