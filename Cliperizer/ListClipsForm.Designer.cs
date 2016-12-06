namespace Cliperizer
{
	partial class ListClipsForm
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
			this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.startTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.endTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nameBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.startTimeBox = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.endTimeBox = new System.Windows.Forms.MaskedTextBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
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
			this.splitContainer.Panel2.Controls.Add(this.deleteButton);
			this.splitContainer.Panel2.Controls.Add(this.applyButton);
			this.splitContainer.Panel2.Controls.Add(this.endTimeBox);
			this.splitContainer.Panel2.Controls.Add(this.label3);
			this.splitContainer.Panel2.Controls.Add(this.startTimeBox);
			this.splitContainer.Panel2.Controls.Add(this.label2);
			this.splitContainer.Panel2.Controls.Add(this.label1);
			this.splitContainer.Panel2.Controls.Add(this.nameBox);
			this.splitContainer.Size = new System.Drawing.Size(557, 375);
			this.splitContainer.SplitterDistance = 400;
			this.splitContainer.TabIndex = 0;
			// 
			// clipList
			// 
			this.clipList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.startTimeHeader,
            this.endTimeHeader});
			this.clipList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clipList.Location = new System.Drawing.Point(0, 0);
			this.clipList.MultiSelect = false;
			this.clipList.Name = "clipList";
			this.clipList.Size = new System.Drawing.Size(400, 375);
			this.clipList.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.clipList.TabIndex = 0;
			this.clipList.UseCompatibleStateImageBehavior = false;
			this.clipList.View = System.Windows.Forms.View.Details;
			this.clipList.SelectedIndexChanged += new System.EventHandler(this.clipList_SelectedIndexChanged);
			// 
			// nameHeader
			// 
			this.nameHeader.Text = "Name";
			this.nameHeader.Width = 221;
			// 
			// startTimeHeader
			// 
			this.startTimeHeader.Text = "Start Time";
			this.startTimeHeader.Width = 86;
			// 
			// endTimeHeader
			// 
			this.endTimeHeader.Text = "End Time";
			this.endTimeHeader.Width = 87;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(6, 25);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(135, 20);
			this.nameBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Start Time:";
			// 
			// startTimeBox
			// 
			this.startTimeBox.Location = new System.Drawing.Point(6, 64);
			this.startTimeBox.Mask = "00:00:00.000";
			this.startTimeBox.Name = "startTimeBox";
			this.startTimeBox.Size = new System.Drawing.Size(135, 20);
			this.startTimeBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "End Time:";
			// 
			// endTimeBox
			// 
			this.endTimeBox.Location = new System.Drawing.Point(6, 103);
			this.endTimeBox.Mask = "00:00:00.000";
			this.endTimeBox.Name = "endTimeBox";
			this.endTimeBox.Size = new System.Drawing.Size(135, 20);
			this.endTimeBox.TabIndex = 6;
			// 
			// applyButton
			// 
			this.applyButton.Enabled = false;
			this.applyButton.Location = new System.Drawing.Point(6, 311);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(135, 23);
			this.applyButton.TabIndex = 7;
			this.applyButton.Text = "Apply";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Enabled = false;
			this.deleteButton.Location = new System.Drawing.Point(6, 340);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(135, 23);
			this.deleteButton.TabIndex = 8;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// ListClipsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 375);
			this.Controls.Add(this.splitContainer);
			this.Name = "ListClipsForm";
			this.Text = "Clips";
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
		private System.Windows.Forms.ColumnHeader nameHeader;
		private System.Windows.Forms.ColumnHeader startTimeHeader;
		private System.Windows.Forms.ColumnHeader endTimeHeader;
		private System.Windows.Forms.MaskedTextBox startTimeBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox endTimeBox;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button applyButton;
	}
}