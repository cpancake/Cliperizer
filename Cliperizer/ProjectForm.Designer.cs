namespace Cliperizer
{
	partial class ProjectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.playButton = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.positionLabel = new System.Windows.Forms.Label();
			this.durationLabel = new System.Windows.Forms.Label();
			this.positionSlider = new System.Windows.Forms.TrackBar();
			this.timelineContainer = new System.Windows.Forms.Panel();
			this.closeButton = new System.Windows.Forms.Button();
			this.clipButton = new System.Windows.Forms.Button();
			this.renderButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.positionSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.renderButton);
			this.splitContainer.Panel2.Controls.Add(this.clipButton);
			this.splitContainer.Panel2.Controls.Add(this.closeButton);
			this.splitContainer.Panel2.Controls.Add(this.playButton);
			this.splitContainer.Panel2.Controls.Add(this.positionLabel);
			this.splitContainer.Panel2.Controls.Add(this.durationLabel);
			this.splitContainer.Panel2.Controls.Add(this.positionSlider);
			this.splitContainer.Panel2.Controls.Add(this.timelineContainer);
			this.splitContainer.Size = new System.Drawing.Size(835, 492);
			this.splitContainer.SplitterDistance = 380;
			this.splitContainer.SplitterWidth = 1;
			this.splitContainer.TabIndex = 0;
			// 
			// playButton
			// 
			this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.playButton.ImageKey = "control_pause.png";
			this.playButton.ImageList = this.imageList;
			this.playButton.Location = new System.Drawing.Point(403, 47);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(29, 23);
			this.playButton.TabIndex = 4;
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "control_play.png");
			this.imageList.Images.SetKeyName(1, "control_pause.png");
			// 
			// positionLabel
			// 
			this.positionLabel.AutoSize = true;
			this.positionLabel.Location = new System.Drawing.Point(12, 52);
			this.positionLabel.Name = "positionLabel";
			this.positionLabel.Size = new System.Drawing.Size(49, 13);
			this.positionLabel.TabIndex = 3;
			this.positionLabel.Text = "00:00:00";
			// 
			// durationLabel
			// 
			this.durationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.durationLabel.AutoSize = true;
			this.durationLabel.Location = new System.Drawing.Point(774, 52);
			this.durationLabel.Name = "durationLabel";
			this.durationLabel.Size = new System.Drawing.Size(49, 13);
			this.durationLabel.TabIndex = 2;
			this.durationLabel.Text = "00:00:00";
			this.durationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// positionSlider
			// 
			this.positionSlider.Dock = System.Windows.Forms.DockStyle.Top;
			this.positionSlider.Location = new System.Drawing.Point(0, 20);
			this.positionSlider.Name = "positionSlider";
			this.positionSlider.Size = new System.Drawing.Size(835, 45);
			this.positionSlider.TabIndex = 1;
			this.positionSlider.TabStop = false;
			this.positionSlider.TickStyle = System.Windows.Forms.TickStyle.None;
			this.positionSlider.Scroll += new System.EventHandler(this.positionSlider_Scroll);
			// 
			// timelineContainer
			// 
			this.timelineContainer.BackColor = System.Drawing.SystemColors.Window;
			this.timelineContainer.Dock = System.Windows.Forms.DockStyle.Top;
			this.timelineContainer.Location = new System.Drawing.Point(0, 0);
			this.timelineContainer.Name = "timelineContainer";
			this.timelineContainer.Size = new System.Drawing.Size(835, 20);
			this.timelineContainer.TabIndex = 0;
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(748, 76);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 5;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// clipButton
			// 
			this.clipButton.Location = new System.Drawing.Point(667, 76);
			this.clipButton.Name = "clipButton";
			this.clipButton.Size = new System.Drawing.Size(75, 23);
			this.clipButton.TabIndex = 6;
			this.clipButton.Text = "List Clips";
			this.clipButton.UseVisualStyleBackColor = true;
			this.clipButton.Click += new System.EventHandler(this.clipButton_Click);
			// 
			// renderButton
			// 
			this.renderButton.Location = new System.Drawing.Point(12, 76);
			this.renderButton.Name = "renderButton";
			this.renderButton.Size = new System.Drawing.Size(75, 23);
			this.renderButton.TabIndex = 7;
			this.renderButton.Text = "Render";
			this.renderButton.UseVisualStyleBackColor = true;
			this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
			// 
			// ProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 492);
			this.Controls.Add(this.splitContainer);
			this.Name = "ProjectForm";
			this.Text = "ProjectForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectForm_FormClosing);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.positionSlider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Panel timelineContainer;
		private System.Windows.Forms.TrackBar positionSlider;
		private System.Windows.Forms.Label durationLabel;
		private System.Windows.Forms.Label positionLabel;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button clipButton;
		private System.Windows.Forms.Button renderButton;
	}
}