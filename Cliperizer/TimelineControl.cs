using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliperizer
{
	public class TimelineControl : Control
	{
		private const double INTERVAL = 5; // 5 second interval
		private const int LINE_PIXEL_INTERVAL = 20; // 20 pixels between lines

		private double _position;
		private double _duration;
		private Clip _currentClip;
		private bool _hasCurrentClip;
		private Pen _currentClipPen;
		private List<Clip> _clips;
		private Font _clipFont;

		public TimelineControl()
		{
			DoubleBuffered = true;
			_clipFont = new Font(FontFamily.GenericSansSerif, 7f);
		}

		public void Update(double position, double duration)
		{
			_position = position * duration;
			_duration = duration;

			Invalidate(new Region(Bounds));
		}

		public void UpdateClips(List<Clip> clips)
		{
			_clips = clips;
		}

		public void SetCurrentClip(Clip c)
		{
			_hasCurrentClip = c != null;
			_currentClip = c;
			if(_currentClip != null)
			{
				_currentClipPen = new Pen(_currentClip.Color);
			}
		}

		private int TimeToXPos(double time)
		{
			return LINE_PIXEL_INTERVAL + (int)Math.Floor((time / INTERVAL * LINE_PIXEL_INTERVAL) - (_position / INTERVAL * LINE_PIXEL_INTERVAL));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			var g = e.Graphics;
			g.Clear(Color.White);

			var minTime = _position - INTERVAL;
			var maxTime = _position + (Width / LINE_PIXEL_INTERVAL * INTERVAL);

			for(var i = 0; i < Math.Floor((_duration - _position) / INTERVAL) + 1; i++)
			{
				var amt = ((_duration - _position) % INTERVAL) / INTERVAL;
				var xPos = LINE_PIXEL_INTERVAL + (int)Math.Floor((i - 1) * LINE_PIXEL_INTERVAL + LINE_PIXEL_INTERVAL * amt);
				g.DrawLine(Pens.Black, new Point(xPos, 0), new Point(xPos, 10));
			}

			g.FillEllipse(Brushes.Red, new Rectangle(LINE_PIXEL_INTERVAL, 0, 10, 10));

			if(_hasCurrentClip)
			{
				var x = TimeToXPos(_currentClip.StartTime);
				g.DrawRectangle(_currentClipPen, new Rectangle(x, 10, TimeToXPos(_position) - x, 10));
			}

			var clips = _clips.Where(c => c.StartTime < maxTime && c.EndTime > minTime);
			foreach(var clip in clips)
			{
				var x = TimeToXPos(clip.StartTime);
				var clipRectangle = new Rectangle(x, 10, TimeToXPos(clip.EndTime) - x, 15);
				g.FillRectangle(clip.ColorBrush, clipRectangle);
				g.SetClip(clipRectangle);
				g.DrawString(clip.Name, _clipFont, Brushes.Black, new PointF(x + 1, 7));
				g.ResetClip();
			}

			base.OnPaint(e);
		}
	}
}
