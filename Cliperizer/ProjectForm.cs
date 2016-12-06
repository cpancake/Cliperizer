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
using Vlc.DotNet.Forms;

namespace Cliperizer
{
	public partial class ProjectForm : Form
	{
		private const int SLIDER_INTERVALS = 1000;
		private const string PLAY_BUTTON_KEY = "control_play.png";
		private const string PAUSE_BUTTON_KEY = "control_pause.png";

		private VideoProject _project;

		private VlcControl _vlcControl;
		private TimelineControl _timelineControl;

		private Timer _timer;
		private Timer _sliderTimer;
		private Dictionary<Keys, bool> _keyPressed = new Dictionary<Keys, bool>();
		private Clip _currentClip = new Clip();
		private bool _isClipStarted = false;

		public ProjectForm(VideoProject project)
		{
			InitializeComponent();

			_project = project;

			_vlcControl = new VlcControl();
			_vlcControl.VlcLibDirectory = new DirectoryInfo(".");
			_vlcControl.VlcLibDirectoryNeeded += (s, e) => { e.VlcLibDirectory = new DirectoryInfo("."); };
			_vlcControl.Dock = DockStyle.Fill;
			_vlcControl.BackColor = SystemColors.Control;
			_vlcControl.EndInit();
			_vlcControl.Play(new FileInfo(project.VideoFile));
			_vlcControl.MouseClick += (s, e) => TogglePause();
			_vlcControl.Position = (float)_project.LastTime;

			_timelineControl = new TimelineControl();
			_timelineControl.Dock = DockStyle.Fill;
			_timelineControl.BackColor = Color.White;
			_timelineControl.UpdateClips(_project.Clips);

			_timer = new Timer();
			_timer.Interval = 100;
			_timer.Tick += Update;
			_timer.Start();

			_sliderTimer = new Timer();
			_sliderTimer.Interval = 500;
			_sliderTimer.Tick += UpdateSlider;
			_sliderTimer.Start();

			splitContainer.Panel1.Controls.Add(_vlcControl);
			timelineContainer.Controls.Add(_timelineControl);

			positionSlider.Maximum = SLIDER_INTERVALS;
			Text = _project.VideoFile;
		}

		private void UpdateSlider(object sender, EventArgs e)
		{
			if(_vlcControl.IsPlaying)
			{
				var durationIncrements = _vlcControl.GetCurrentMedia().Duration.TotalSeconds / SLIDER_INTERVALS;
				var newTime = (int)Math.Floor((_vlcControl.Position * _vlcControl.GetCurrentMedia().Duration.TotalSeconds) / durationIncrements);
				positionSlider.Value = Math.Min(SLIDER_INTERVALS, Math.Max(0, newTime));
			}
		}

		private void Update(object sender, EventArgs e)
		{
			if(_keyPressed.ContainsKey(Keys.Left) && _keyPressed[Keys.Left])
			{
				SkipBack(GetSkipTime());
			}
			else if(_keyPressed.ContainsKey(Keys.Right) && _keyPressed[Keys.Right])
			{
				SkipForward(GetSkipTime());
			}

			_timelineControl.Update(_vlcControl.Position, _vlcControl.GetCurrentMedia().Duration.TotalSeconds);

			positionLabel.Text = TimeSpan.FromSeconds(_vlcControl.Position * _vlcControl.GetCurrentMedia().Duration.TotalSeconds).ToString(@"hh\:mm\:ss");
			durationLabel.Text = _vlcControl.GetCurrentMedia().Duration.ToString(@"hh\:mm\:ss");
		}

		private float GetSkipTime()
		{
			return 0.5f;
		}

		private void TogglePause()
		{
			if(_vlcControl.IsPlaying)
			{
				_vlcControl.Pause();
				playButton.ImageKey = PLAY_BUTTON_KEY;
			}
			else
			{
				_vlcControl.Play();
				playButton.ImageKey = PAUSE_BUTTON_KEY;
			}
		}

		private void SkipBack(float interval)
		{
			var duration = _vlcControl.GetCurrentMedia().Duration.TotalSeconds;
			var newPos = Math.Max(0, duration * _vlcControl.Position - interval);
			_vlcControl.Position = (float)(newPos / duration);
		}

		private void SkipForward(float interval)
		{
			var duration = _vlcControl.GetCurrentMedia().Duration.TotalSeconds;
			var newPos = Math.Min(duration, duration * _vlcControl.Position + interval);
			_vlcControl.Position = (float)(newPos / duration);
		}

		private void SetStartPoint()
		{
			_isClipStarted = true;
			_currentClip.StartTime = _vlcControl.Position * _vlcControl.GetCurrentMedia().Duration.TotalSeconds;
			_currentClip.Color = Clip.GenerateRandomColor();
			_timelineControl.SetCurrentClip(_currentClip);
		}

		private void SetEndPoint()
		{
			_currentClip.EndTime = _vlcControl.Position * _vlcControl.GetCurrentMedia().Duration.TotalSeconds;
			_vlcControl.Pause();

			var dialog = new ConfirmClipDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				_currentClip.Name = dialog.ClipName;
				_project.Clips.Add(_currentClip);
				_timelineControl.UpdateClips(_project.Clips);
				_project.Save();
			}

			_currentClip = new Clip();
			_vlcControl.Play();
			_timelineControl.SetCurrentClip(null);
		}

		private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_project.LastTime = _vlcControl.Position;
			_vlcControl.Stop();
			_project.Save();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void positionSlider_Scroll(object sender, EventArgs e)
		{
			_vlcControl.Position = (float)positionSlider.Value / SLIDER_INTERVALS;

			_sliderTimer.Stop();
			_sliderTimer.Start();
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			TogglePause();
		}

		private void clipButton_Click(object sender, EventArgs e)
		{
			var dialog = new ListClipsForm(_project);
			dialog.ShowDialog();
			_timelineControl.UpdateClips(_project.Clips);
		}

		private void renderButton_Click(object sender, EventArgs e)
		{
			var dialog = new RenderForm(_project);
			dialog.ShowDialog();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Space)
				TogglePause();
			else if(keyData == Keys.D1)
				SetStartPoint();
			else if(keyData == Keys.D2)
				SetEndPoint();
			_keyPressed[keyData] = msg.Msg == 0x100;
			return base.ProcessCmdKey(ref msg, keyData);
		}

		protected override bool ProcessKeyPreview(ref Message m)
		{
			var key = (Keys)m.WParam;
			_keyPressed[key] = m.Msg != 0x101;
			return base.ProcessKeyPreview(ref m);
		}
	}
}
