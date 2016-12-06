using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliperizer
{
	public partial class MainForm : Form
	{
		private List<string> _recentFiles;

		public MainForm()
		{
			InitializeComponent();

			_recentFiles = new List<string>(RecentManager.ReadRecent());
			recentBox.Items.AddRange(_recentFiles.ToArray());
		}

		private void newProjectButton_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Title = "Select Video File";
			dialog.Filter = "Video Files (*.avi, *.mp4, *.mpeg, *.mkv, *.webm)|*.avi;*.mp4;*.mpeg;*.mkv;*.webm|All Files (*.*)|*.*";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				var file = dialog.FileName;
				var projectFile = Path.Combine(Path.GetDirectoryName(file), Path.GetFileNameWithoutExtension(file) + ".clip-project");
				if(File.Exists(projectFile))
				{
					OpenProject(VideoProject.Load(projectFile));
				}
				else
				{
					var project = new VideoProject(file, projectFile);
					project.Save();
					OpenProject(project);
				}
			}
		}

		private void openProjectButton_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.Title = "Select Project File";
			dialog.Filter = "Project Files (*.clip-project)|*.clip-project|All Files (*.*)|*.*";
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				OpenProject(VideoProject.Load(dialog.FileName));
			}
		}

		private void OpenProject(VideoProject project)
		{
			_recentFiles.Add(project.ProjectFile);
			_recentFiles.Reverse();
			_recentFiles = _recentFiles.Distinct().Take(10).ToList();

			recentBox.Items.Clear();
			recentBox.Items.AddRange(_recentFiles.ToArray());
			RecentManager.WriteRecent(_recentFiles);
			var form = new ProjectForm(project);
			form.ShowDialog();
		}

		private void recentBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(recentBox.SelectedItems.Count == 0) return;
			OpenProject(VideoProject.Load(recentBox.SelectedItem.ToString()));
		}

		private void clearMenuItem_Click(object sender, EventArgs e)
		{
			recentBox.Items.Clear();
			RecentManager.ClearItems();
		}
	}
}
