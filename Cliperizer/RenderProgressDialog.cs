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
	public partial class RenderProgressDialog : Form
	{
		private int _totalItems = 0;
		private int _itemsFinished = 0;
		
		public int ItemsFinished
		{
			get { return _itemsFinished; }
			set
			{
				_itemsFinished = value;
				if(_itemsFinished == _totalItems)
					Close();
				clipProgressBar.Value = _itemsFinished / _totalItems;
				progressLabel.Text = $"Rendering your clips ({_itemsFinished}/{_totalItems})...";
			}
		}

		public RenderProgressDialog(int totalItems)
		{
			InitializeComponent();
		}
	}
}
