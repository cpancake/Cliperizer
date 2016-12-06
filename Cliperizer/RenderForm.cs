using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Ookii.Dialogs;

namespace Cliperizer
{
	public partial class RenderForm : Form
	{
		private VideoProject _project;

		private Dictionary<string, string> _codecs = new Dictionary<string, string>();
		private Dictionary<string, string[]> _codecQualitySettings = new Dictionary<string, string[]>()
		{
			{ "WebM", new string[] { "-qmin 0 -qmax 50 -b:v 5M", "-qmin 2 -qmax 55 -b:v 3M", "-qmin 2 -qmax 55 -b:v 2M", "-qmin 4 -qmax 60 -b:v 750K", "-qmin 4 -qmax 63 -b:v 300K" } },
			{ "NVENC MPEG-4 AVC", new string[] { "-b:v 5M", "-b:v 3M", "-b:v 2M", " -b:v 750K", "-b:v 300k" } },
			{ "MPEG-4 AVC", new string[] { "-crf 18 -preset slower", "-crf 18 -preset slow", "-crf 20 -preset medium", "-crf 25 -preset fast", "-crf 28 -preset veryfast" } }
		};

		public RenderForm(VideoProject project)
		{
			InitializeComponent();
			_project = project;
			clipList.Items.AddRange(_project.Clips.Select(c => new ListViewItem(c.Name) { Checked = true, Tag = c }).ToArray());
			qualityBox.SelectedIndex = 2;

			if(!FFmpeg.CheckIfInstalled())
			{
				MessageBox.Show("FFmpeg not found in path. Please download and install before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			// determine supported output formats
			var formats = new HashSet<string>(FFmpeg.ListSupportedFormats());
			if(formats.Contains("libvpx") && formats.Contains("libvorbis"))
			{
				_codecs["WebM"] = "-c:v libvpx -c:a libvorbis -cpu-used 8";
			}

			if(formats.Contains("nvenc"))
			{
				if(formats.Contains("libfdk-aac"))
				{
					_codecs["NVENC MPEG-4 AVC"] = "-c:v nvenc_h264 -c:a libfdk_aac";
				}
				else
				{
					_codecs["NVENC MPEG-4 AVC"] = "-c:v nvenc_h264 -c:a aac";
				}
			}

			if(formats.Contains("libx264"))
			{
				if(formats.Contains("libfdk-aac"))
				{
					_codecs["MPEG-4 AVC"] = "-c:v libx264 -c:a libfdk_aac";
				}
				else
				{
					_codecs["MPEG-4 AVC"] = "-c:v libx264 -c:a aac";
				}
			}

			if(formats.Count == 0)
			{
				MessageBox.Show("No supported codecs are enabled in FFmpeg. Get a newer build.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			codecBox.Items.AddRange(_codecs.Keys.ToArray());
			codecBox.SelectedIndex = 0;
		}

		private void DoRender(bool concat = false)
		{
			if(!Directory.Exists(directoryBox.Text))
			{
				MessageBox.Show("The directory you've selected doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var clips = new List<Clip>();
			foreach(var oitem in clipList.Items)
			{
				var item = oitem as ListViewItem;
				if(!item.Checked) continue;
				clips.Add(item.Tag as Clip);
			}

			var codec = _codecs[codecBox.SelectedItem.ToString()];
			var includeAudio = audioCheckbox.Checked;
			var quality = _codecQualitySettings[codecBox.SelectedItem.ToString()][qualityBox.SelectedIndex];
			var outputDir = directoryBox.Text;

			var ext = codecBox.SelectedItem.ToString() == "WebM" ? ".webm" : ".mp4";
			var files = new List<string>();

			var progressDialog = new ProgressDialog();
			progressDialog.DoWork += (s, _e) =>
			{
				progressDialog.ReportProgress(0, "Rendering", $"Rendering clips (1/{clips.Count})...");
				var currentNum = 0;
				foreach(var clip in clips)
				{
					var filename = MakeValidFileName(clip.Name);
					var currentName = filename;
					var i = 1;
					while(File.Exists(Path.Combine(outputDir, currentName + ext)))
					{
						currentName = filename + i++;
					}
					FFmpeg.RenderClip(
						_project.VideoFile,
						Path.Combine(outputDir, currentName + ext),
						codec,
						includeAudio,
						quality,
						TimeSpan.FromSeconds(clip.StartTime),
						TimeSpan.FromSeconds(clip.EndTime)
					);
					files.Add(Path.Combine(outputDir, currentName + ext));
					progressDialog.ReportProgress((int)((++currentNum / (float)clips.Count) * 100), "Rendering", $"Rendering clips ({currentNum + 1}/{clips.Count})...");
				}

				if(concat)
				{
					progressDialog.ReportProgress(100, "Rendering", "Concatenating files...");
					var filename = "concat" + ext;
					var i = 0;
					while(File.Exists(Path.Combine(outputDir, filename)))
					{
						filename = "concat" + i++ + ext;
					}
					FFmpeg.ConcatClips(files.ToArray(), Path.Combine(outputDir, filename));
				}
			};
			progressDialog.ShowDialog();
		}

		private void directoryBox_Click(object sender, EventArgs e)
		{
			browseButton.PerformClick();
		}

		private void browseButton_Click(object sender, EventArgs e)
		{
			var dialog = new VistaFolderBrowserDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				directoryBox.Text = dialog.SelectedPath;
			}
		}

		private void renderButton_Click(object sender, EventArgs e)
		{
			DoRender(false);
		}

		private static string MakeValidFileName(string name)
		{
			string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
			string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

			return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "_");
		}

		private void renderConcatButton_Click(object sender, EventArgs e)
		{
			DoRender(true);
		}
	}
}
