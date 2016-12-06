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
	public partial class ConfirmClipDialog : Form
	{
		private string _clipName;

		public string ClipName => _clipName;

		public ConfirmClipDialog()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(clipNameBox.Text)) return;
			_clipName = clipNameBox.Text;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
