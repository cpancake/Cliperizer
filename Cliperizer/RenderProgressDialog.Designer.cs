namespace Cliperizer
{
	partial class RenderProgressDialog
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
			this.progressLabel = new System.Windows.Forms.Label();
			this.clipProgressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// progressLabel
			// 
			this.progressLabel.AutoSize = true;
			this.progressLabel.Location = new System.Drawing.Point(12, 9);
			this.progressLabel.Name = "progressLabel";
			this.progressLabel.Size = new System.Drawing.Size(138, 13);
			this.progressLabel.TabIndex = 0;
			this.progressLabel.Text = "Rendering your clips (0/0)...";
			// 
			// clipProgressBar
			// 
			this.clipProgressBar.Location = new System.Drawing.Point(12, 25);
			this.clipProgressBar.Name = "clipProgressBar";
			this.clipProgressBar.Size = new System.Drawing.Size(508, 35);
			this.clipProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.clipProgressBar.TabIndex = 1;
			// 
			// RenderProgressDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 72);
			this.Controls.Add(this.clipProgressBar);
			this.Controls.Add(this.progressLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "RenderProgressDialog";
			this.Text = "Rendering...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label progressLabel;
		private System.Windows.Forms.ProgressBar clipProgressBar;
	}
}