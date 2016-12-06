using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliperizer
{
	public class Clip
	{
		public string Name;
		public double StartTime;
		public double EndTime;
		public Color Color;

		private Brush _colorBrush;
		
		// Yes, a getter that mutates state. I'm the worst!
		public Brush ColorBrush => (_colorBrush == null ? _colorBrush = new SolidBrush(Color) : _colorBrush);

		public static Color GenerateRandomColor()
		{
			var rand = new Random();
			return Color.FromArgb(
				(int)((255f + rand.Next(0, 255)) / 2),
				(int)((255f + rand.Next(0, 255)) / 2),
				(int)((255f + rand.Next(0, 255)) / 2)
			);
		}
	}
}
