namespace Cliperizer
{
	partial class MainForm
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
			this.newProjectButton = new System.Windows.Forms.Button();
			this.openProjectButton = new System.Windows.Forms.Button();
			this.recentBox = new System.Windows.Forms.ListBox();
			this.recentBoxContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentBoxContextStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// newProjectButton
			// 
			this.newProjectButton.Location = new System.Drawing.Point(12, 12);
			this.newProjectButton.Name = "newProjectButton";
			this.newProjectButton.Size = new System.Drawing.Size(102, 23);
			this.newProjectButton.TabIndex = 0;
			this.newProjectButton.Text = "New Project";
			this.newProjectButton.UseVisualStyleBackColor = true;
			this.newProjectButton.Click += new System.EventHandler(this.newProjectButton_Click);
			// 
			// openProjectButton
			// 
			this.openProjectButton.Location = new System.Drawing.Point(120, 12);
			this.openProjectButton.Name = "openProjectButton";
			this.openProjectButton.Size = new System.Drawing.Size(102, 23);
			this.openProjectButton.TabIndex = 1;
			this.openProjectButton.Text = "Open Project";
			this.openProjectButton.UseVisualStyleBackColor = true;
			this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
			// 
			// recentBox
			// 
			this.recentBox.ContextMenuStrip = this.recentBoxContextStrip;
			this.recentBox.FormattingEnabled = true;
			this.recentBox.Location = new System.Drawing.Point(12, 41);
			this.recentBox.Name = "recentBox";
			this.recentBox.Size = new System.Drawing.Size(210, 238);
			this.recentBox.TabIndex = 2;
			this.recentBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.recentBox_MouseDoubleClick);
			// 
			// recentBoxContextStrip
			// 
			this.recentBoxContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenuItem});
			this.recentBoxContextStrip.Name = "contextMenuStrip1";
			this.recentBoxContextStrip.Size = new System.Drawing.Size(153, 48);
			// 
			// clearMenuItem
			// 
			this.clearMenuItem.Name = "clearMenuItem";
			this.clearMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clearMenuItem.Text = "Clear Items";
			this.clearMenuItem.Click += new System.EventHandler(this.clearMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 294);
			this.Controls.Add(this.recentBox);
			this.Controls.Add(this.openProjectButton);
			this.Controls.Add(this.newProjectButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "Cliperizer";
			this.recentBoxContextStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button newProjectButton;
		private System.Windows.Forms.Button openProjectButton;
		private System.Windows.Forms.ListBox recentBox;
		private System.Windows.Forms.ContextMenuStrip recentBoxContextStrip;
		private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
	}
}

