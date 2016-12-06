using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliperizer
{
	public class VideoProject
	{
		private string _videoFile;
		private string _projectFile;

		public List<Clip> Clips = new List<Clip>();
		public double LastTime = 0;

		public string VideoFile => _videoFile;
		public string ProjectFile => _projectFile;

		public VideoProject(string videoFile, string projectFile)
		{
			_videoFile = videoFile;
			_projectFile = projectFile;
		}

		public void Save()
		{
			using(var stream = File.OpenWrite(_projectFile))
			{
				using(var writer = new StreamWriter(stream))
				{
					writer.WriteLine("--cliperizer--");
					writer.WriteLine("1");
					writer.WriteLine(_videoFile);
					writer.WriteLine(LastTime);
					writer.WriteLine(Clips.Count);
					writer.WriteLine("--");
					foreach(var clip in Clips)
					{
						writer.WriteLine(clip.Name);
						writer.WriteLine(clip.StartTime);
						writer.WriteLine(clip.EndTime);
						writer.Write(clip.Color.R);
						writer.Write(",");
						writer.Write(clip.Color.G);
						writer.Write(",");
						writer.WriteLine(clip.Color.B);
					}
				}
			}
		}

		public static VideoProject Load(string file)
		{
			using(var stream = File.OpenRead(file))
			{
				using(var reader = new StreamReader(stream))
				{
					var magic = reader.ReadLine();
					if(magic != "--cliperizer--")
					{
						throw new InvalidDataException("Invalid project file.");
					}

					var version = reader.ReadLine();
					if(version != "1")
					{
						throw new InvalidDataException("Unsupported project version: " + version);
					}

					var videoFile = reader.ReadLine();
					var project = new VideoProject(videoFile, file);
					project.LastTime = double.Parse(reader.ReadLine());

					var clipCount = int.Parse(reader.ReadLine());
					reader.ReadLine();

					for(var i = 0; i < clipCount; i++)
					{
						var clip = new Clip();
						clip.Name = reader.ReadLine();
						clip.StartTime = double.Parse(reader.ReadLine());
						clip.EndTime = double.Parse(reader.ReadLine());
						var colorParts = reader.ReadLine().Split(',');
						clip.Color = Color.FromArgb(int.Parse(colorParts[0]), int.Parse(colorParts[1]), int.Parse(colorParts[2]));
						project.Clips.Add(clip);
					}

					return project;
				}
			}
		}
	}
}
