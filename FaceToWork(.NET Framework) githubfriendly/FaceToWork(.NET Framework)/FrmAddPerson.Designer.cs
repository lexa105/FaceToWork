
namespace FaceToWork
{
	partial class FrmAddPerson
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
			if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPerson));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AcceptBtn = new System.Windows.Forms.Button();
			this.Name_txtBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.GroupNameLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnBrowseFaceFile = new System.Windows.Forms.Button();
			this.ListFolderPath = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(330, 121);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(53, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Person Name";
			// 
			// AcceptBtn
			// 
			this.AcceptBtn.Location = new System.Drawing.Point(292, 498);
			this.AcceptBtn.Name = "AcceptBtn";
			this.AcceptBtn.Size = new System.Drawing.Size(94, 31);
			this.AcceptBtn.TabIndex = 7;
			this.AcceptBtn.Text = "OK";
			this.AcceptBtn.UseVisualStyleBackColor = true;
			this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
			// 
			// Name_txtBox
			// 
			this.Name_txtBox.Location = new System.Drawing.Point(54, 241);
			this.Name_txtBox.Name = "Name_txtBox";
			this.Name_txtBox.Size = new System.Drawing.Size(330, 20);
			this.Name_txtBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(53, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Adding Person to ";
			// 
			// GroupNameLabel
			// 
			this.GroupNameLabel.AutoSize = true;
			this.GroupNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.GroupNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.GroupNameLabel.Location = new System.Drawing.Point(173, 169);
			this.GroupNameLabel.Name = "GroupNameLabel";
			this.GroupNameLabel.Size = new System.Drawing.Size(13, 17);
			this.GroupNameLabel.TabIndex = 3;
			this.GroupNameLabel.Text = "-";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(51, 284);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Persons image folder";
			// 
			// btnBrowseFaceFile
			// 
			this.btnBrowseFaceFile.Location = new System.Drawing.Point(310, 298);
			this.btnBrowseFaceFile.Name = "btnBrowseFaceFile";
			this.btnBrowseFaceFile.Size = new System.Drawing.Size(34, 20);
			this.btnBrowseFaceFile.TabIndex = 19;
			this.btnBrowseFaceFile.Text = "...";
			this.btnBrowseFaceFile.UseVisualStyleBackColor = true;
			this.btnBrowseFaceFile.Click += new System.EventHandler(this.btnBrowseFaceFile_Click);
			// 
			// ListFolderPath
			// 
			this.ListFolderPath.FormattingEnabled = true;
			this.ListFolderPath.Location = new System.Drawing.Point(54, 300);
			this.ListFolderPath.Name = "ListFolderPath";
			this.ListFolderPath.Size = new System.Drawing.Size(250, 173);
			this.ListFolderPath.TabIndex = 21;
			// 
			// FrmAddPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 541);
			this.Controls.Add(this.ListFolderPath);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnBrowseFaceFile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AcceptBtn);
			this.Controls.Add(this.Name_txtBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.GroupNameLabel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmAddPerson";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmAddPerson";
			this.Load += new System.EventHandler(this.FrmAddPerson_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AcceptBtn;
		private System.Windows.Forms.TextBox Name_txtBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label GroupNameLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnBrowseFaceFile;
		private System.Windows.Forms.ListBox ListFolderPath;
	}
}