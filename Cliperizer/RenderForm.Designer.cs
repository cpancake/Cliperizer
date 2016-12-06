namespace Cliperizer
{
	partial class RenderForm
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
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.clipList = new System.Windows.Forms.ListView();
			this.codecBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.audioCheckbox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.directoryBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.renderButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.qualityBox = new System.Windows.Forms.ComboBox();
			this.renderConcatButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.clipList);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.renderConcatButton);
			this.splitContainer.Panel2.Controls.Add(this.qualityBox);
			this.splitContainer.Panel2.Controls.Add(this.label2);
			this.splitContainer.Panel2.Controls.Add(this.renderButton);
			this.splitContainer.Panel2.Controls.Add(this.browseButton);
			this.splitContainer.Panel2.Controls.Add(this.directoryBox);
			this.splitContainer.Panel2.Controls.Add(this.label3);
			this.splitContainer.Panel2.Controls.Add(this.audioCheckbox);
			this.splitContainer.Panel2.Controls.Add(this.label1);
			this.splitContainer.Panel2.Controls.Add(this.codecBox);
			this.splitContainer.Size = new System.Drawing.Size(465, 367);
			this.splitContainer.SplitterDistance = 238;
			this.splitContainer.TabIndex = 0;
			// 
			// clipList
			// 
			this.clipList.CheckBoxes = true;
			this.clipList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clipList.Location = new System.Drawing.Point(0, 0);
			this.clipList.Name = "clipList";
			this.clipList.Size = new System.Drawing.Size(238, 367);
			this.clipList.TabIndex = 0;
			this.clipList.UseCompatibleStateImageBehavior = false;
			this.clipList.View = System.Windows.Forms.View.List;
			// 
			// codecBox
			// 
			this.codecBox.FormattingEnabled = true;
			this.codecBox.Location = new System.Drawing.Point(6, 25);
			this.codecBox.Name = "codecBox";
			this.codecBox.Size = new System.Drawing.Size(205, 21);
			this.codecBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Codec:";
			// 
			// audioCheckbox
			// 
			this.audioCheckbox.AutoSize = true;
			this.audioCheckbox.Checked = true;
			this.audioCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.audioCheckbox.Location = new System.Drawing.Point(6, 52);
			this.audioCheckbox.Name = "audioCheckbox";
			this.audioCheckbox.Size = new System.Drawing.Size(91, 17);
			this.audioCheckbox.TabIndex = 2;
			this.audioCheckbox.Text = "Include Audio";
			this.audioCheckbox.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Output Directory:";
			// 
			// directoryBox
			// 
			this.directoryBox.Location = new System.Drawing.Point(6, 128);
			this.directoryBox.Name = "directoryBox";
			this.directoryBox.Size = new System.Drawing.Size(174, 20);
			this.directoryBox.TabIndex = 6;
			this.directoryBox.Click += new System.EventHandler(this.directoryBox_Click);
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(186, 128);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(25, 20);
			this.browseButton.TabIndex = 7;
			this.browseButton.Text = "...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// renderButton
			// 
			this.renderButton.Location = new System.Drawing.Point(6, 303);
			this.renderButton.Name = "renderButton";
			this.renderButton.Size = new System.Drawing.Size(205, 23);
			this.renderButton.TabIndex = 8;
			this.renderButton.Text = "Render";
			this.renderButton.UseVisualStyleBackColor = true;
			this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Quality:";
			// 
			// qualityBox
			// 
			this.qualityBox.FormattingEnabled = true;
			this.qualityBox.Items.AddRange(new object[] {
            "Best",
            "High",
            "Normal",
            "Low",
            "Worst"});
			this.qualityBox.Location = new System.Drawing.Point(6, 88);
			this.qualityBox.Name = "qualityBox";
			this.qualityBox.Size = new System.Drawing.Size(205, 21);
			this.qualityBox.TabIndex = 11;
			// 
			// renderConcatButton
			// 
			this.renderConcatButton.Location = new System.Drawing.Point(6, 332);
			this.renderConcatButton.Name = "renderConcatButton";
			this.renderConcatButton.Size = new System.Drawing.Size(205, 23);
			this.renderConcatButton.TabIndex = 12;
			this.renderConcatButton.Text = "Render and Concat";
			this.renderConcatButton.UseVisualStyleBackColor = true;
			this.renderConcatButton.Click += new System.EventHandler(this.renderConcatButton_Click);
			// 
			// RenderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 367);
			this.Controls.Add(this.splitContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "RenderForm";
			this.Text = "Render Clips";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListView clipList;
		private System.Windows.Forms.ComboBox codecBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox audioCheckbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox directoryBox;
		private System.Windows.Forms.Button renderButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox qualityBox;
		private System.Windows.Forms.Button renderConcatButton;
	}
}