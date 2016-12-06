using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliperizer
{
	public partial class ListClipsForm : Form
	{
		private VideoProject _project;

		public ListClipsForm(VideoProject project)
		{
			InitializeComponent();
			_project = project;
			UpdateList();
		}

		private void UpdateList()
		{
			clipList.Items.Clear();
			foreach(var clip in _project.Clips)
			{
				var item = new ListViewItem();
				item.Text = clip.Name;
				item.SubItems.Add(TimeSpan.FromSeconds(clip.StartTime).ToString());
				item.SubItems.Add(TimeSpan.FromSeconds(clip.EndTime).ToString());
				item.Tag = clip;
				clipList.Items.Add(item);
			}
			clipList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			clipList.Columns[0].Width = -2;
		}

		private void applyButton_Click(object sender, EventArgs e)
		{
			var clip = (Clip)clipList.SelectedItems[0].Tag;
			clip.Name = nameBox.Text;
			clip.StartTime = TimeSpan.Parse(startTimeBox.Text).TotalSeconds;
			clip.EndTime = TimeSpan.Parse(endTimeBox.Text).TotalSeconds;
			_project.Save();
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if(
				MessageBox.Show(
					"Are you sure you want to delete this clip?", 
					"Are you sure?", 
					MessageBoxButtons.YesNo, 
					MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				var clip = (Clip)clipList.SelectedItems[0].Tag;
				_project.Clips.Remove(clip);
				_project.Save();
				UpdateList();
				applyButton.Enabled = false;
				deleteButton.Enabled = false;
			}
		}

		private void clipList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(clipList.SelectedItems.Count == 0) return;

			applyButton.Enabled = true;
			deleteButton.Enabled = true;
			var clip = (Clip)clipList.SelectedItems[0].Tag;
			nameBox.Text = clip.Name;
			startTimeBox.Text = TimeSpan.FromSeconds(clip.StartTime).ToString();
			endTimeBox.Text = TimeSpan.FromSeconds(clip.EndTime).ToString();
		}
	}
}
