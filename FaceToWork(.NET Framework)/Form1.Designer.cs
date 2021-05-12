
namespace FaceToWork_.NET_Framework_
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.optionPanel = new System.Windows.Forms.Panel();
			this.QnA_btn = new System.Windows.Forms.Button();
			this.domu_btn = new System.Windows.Forms.Button();
			this.dochazka_btn = new System.Windows.Forms.Button();
			this.nastaveni_btn = new System.Windows.Forms.Button();
			this.SidePanel_blue = new System.Windows.Forms.Panel();
			this.logoBox = new System.Windows.Forms.PictureBox();
			this.panelTop = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cboCameraDevices = new System.Windows.Forms.ComboBox();
			this.OnCamera = new System.Windows.Forms.Button();
			this.StopCamera = new System.Windows.Forms.Button();
			this.btnProcess = new System.Windows.Forms.Button();
			this.btnTrain = new System.Windows.Forms.Button();
			this.btnIdentify = new System.Windows.Forms.Button();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNewUser = new System.Windows.Forms.TextBox();
			this.listUsers = new System.Windows.Forms.ListBox();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnCreateGroup = new System.Windows.Forms.Button();
			this.dochazkaControl1 = new FaceToWork_.NET_Framework_.DochazkaControl();
			this.optionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.optionPanel.Controls.Add(this.QnA_btn);
			this.optionPanel.Controls.Add(this.domu_btn);
			this.optionPanel.Controls.Add(this.dochazka_btn);
			this.optionPanel.Controls.Add(this.nastaveni_btn);
			this.optionPanel.Controls.Add(this.SidePanel_blue);
			this.optionPanel.Controls.Add(this.logoBox);
			this.optionPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.optionPanel.Location = new System.Drawing.Point(0, 0);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(226, 716);
			this.optionPanel.TabIndex = 0;
			// 
			// QnA_btn
			// 
			this.QnA_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.QnA_btn.FlatAppearance.BorderSize = 0;
			this.QnA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.QnA_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.QnA_btn.ForeColor = System.Drawing.Color.White;
			this.QnA_btn.Image = ((System.Drawing.Image)(resources.GetObject("QnA_btn.Image")));
			this.QnA_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.QnA_btn.Location = new System.Drawing.Point(12, 669);
			this.QnA_btn.Name = "QnA_btn";
			this.QnA_btn.Size = new System.Drawing.Size(36, 35);
			this.QnA_btn.TabIndex = 1;
			this.QnA_btn.UseVisualStyleBackColor = true;
			this.QnA_btn.Click += new System.EventHandler(this.QnA_btn_Click);
			// 
			// domu_btn
			// 
			this.domu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.domu_btn.FlatAppearance.BorderSize = 0;
			this.domu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.domu_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.domu_btn.ForeColor = System.Drawing.Color.White;
			this.domu_btn.Image = ((System.Drawing.Image)(resources.GetObject("domu_btn.Image")));
			this.domu_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.domu_btn.Location = new System.Drawing.Point(25, 213);
			this.domu_btn.Name = "domu_btn";
			this.domu_btn.Size = new System.Drawing.Size(201, 61);
			this.domu_btn.TabIndex = 2;
			this.domu_btn.Text = "            DOMŮ";
			this.domu_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.domu_btn.UseVisualStyleBackColor = true;
			this.domu_btn.Click += new System.EventHandler(this.domu_btn_Click);
			// 
			// dochazka_btn
			// 
			this.dochazka_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dochazka_btn.FlatAppearance.BorderSize = 0;
			this.dochazka_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dochazka_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dochazka_btn.ForeColor = System.Drawing.Color.White;
			this.dochazka_btn.Image = ((System.Drawing.Image)(resources.GetObject("dochazka_btn.Image")));
			this.dochazka_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dochazka_btn.Location = new System.Drawing.Point(25, 280);
			this.dochazka_btn.Name = "dochazka_btn";
			this.dochazka_btn.Size = new System.Drawing.Size(201, 61);
			this.dochazka_btn.TabIndex = 3;
			this.dochazka_btn.Text = "            DOCHÁZKA";
			this.dochazka_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dochazka_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.dochazka_btn.UseVisualStyleBackColor = false;
			this.dochazka_btn.Click += new System.EventHandler(this.dochazka_btn_Click);
			// 
			// nastaveni_btn
			// 
			this.nastaveni_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.nastaveni_btn.FlatAppearance.BorderSize = 0;
			this.nastaveni_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nastaveni_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.nastaveni_btn.ForeColor = System.Drawing.Color.White;
			this.nastaveni_btn.Image = ((System.Drawing.Image)(resources.GetObject("nastaveni_btn.Image")));
			this.nastaveni_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.nastaveni_btn.Location = new System.Drawing.Point(25, 347);
			this.nastaveni_btn.Name = "nastaveni_btn";
			this.nastaveni_btn.Size = new System.Drawing.Size(201, 61);
			this.nastaveni_btn.TabIndex = 3;
			this.nastaveni_btn.Text = "            NASTAVENÍ";
			this.nastaveni_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.nastaveni_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.nastaveni_btn.UseVisualStyleBackColor = false;
			this.nastaveni_btn.Click += new System.EventHandler(this.nastaveni_btn_Click);
			// 
			// SidePanel_blue
			// 
			this.SidePanel_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
			this.SidePanel_blue.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.SidePanel_blue.Location = new System.Drawing.Point(0, 213);
			this.SidePanel_blue.Name = "SidePanel_blue";
			this.SidePanel_blue.Size = new System.Drawing.Size(10, 61);
			this.SidePanel_blue.TabIndex = 3;
			// 
			// logoBox
			// 
			this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
			this.logoBox.Location = new System.Drawing.Point(0, 0);
			this.logoBox.Name = "logoBox";
			this.logoBox.Size = new System.Drawing.Size(226, 216);
			this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.logoBox.TabIndex = 2;
			this.logoBox.TabStop = false;
			// 
			// panelTop
			// 
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(226, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(1136, 39);
			this.panelTop.TabIndex = 1;
			this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
			this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
			// 
			// btnExit
			// 
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(1312, 21);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(38, 35);
			this.btnExit.TabIndex = 1;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.exit_btn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(253, 81);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(640, 340);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// cboCameraDevices
			// 
			this.cboCameraDevices.FormattingEnabled = true;
			this.cboCameraDevices.Location = new System.Drawing.Point(253, 427);
			this.cboCameraDevices.Name = "cboCameraDevices";
			this.cboCameraDevices.Size = new System.Drawing.Size(262, 21);
			this.cboCameraDevices.TabIndex = 3;
			this.cboCameraDevices.SelectedIndexChanged += new System.EventHandler(this.cboCameraDevices_SelectedIndexChanged);
			// 
			// OnCamera
			// 
			this.OnCamera.Location = new System.Drawing.Point(253, 589);
			this.OnCamera.Name = "OnCamera";
			this.OnCamera.Size = new System.Drawing.Size(262, 53);
			this.OnCamera.TabIndex = 4;
			this.OnCamera.Text = "Zapnout Kamery";
			this.OnCamera.UseVisualStyleBackColor = true;
			this.OnCamera.Click += new System.EventHandler(this.button2_Click);
			// 
			// StopCamera
			// 
			this.StopCamera.Location = new System.Drawing.Point(528, 589);
			this.StopCamera.Name = "StopCamera";
			this.StopCamera.Size = new System.Drawing.Size(262, 53);
			this.StopCamera.TabIndex = 4;
			this.StopCamera.Text = "Vypnout kamery";
			this.StopCamera.UseVisualStyleBackColor = true;
			this.StopCamera.Click += new System.EventHandler(this.StopCamera_Click);
			// 
			// btnProcess
			// 
			this.btnProcess.Location = new System.Drawing.Point(846, 607);
			this.btnProcess.Name = "btnProcess";
			this.btnProcess.Size = new System.Drawing.Size(132, 35);
			this.btnProcess.TabIndex = 6;
			this.btnProcess.Text = "Process";
			this.btnProcess.UseVisualStyleBackColor = true;
			this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// btnTrain
			// 
			this.btnTrain.Location = new System.Drawing.Point(984, 607);
			this.btnTrain.Name = "btnTrain";
			this.btnTrain.Size = new System.Drawing.Size(132, 35);
			this.btnTrain.TabIndex = 6;
			this.btnTrain.Text = "Train";
			this.btnTrain.UseVisualStyleBackColor = true;
			// 
			// btnIdentify
			// 
			this.btnIdentify.Location = new System.Drawing.Point(1122, 607);
			this.btnIdentify.Name = "btnIdentify";
			this.btnIdentify.Size = new System.Drawing.Size(132, 35);
			this.btnIdentify.TabIndex = 6;
			this.btnIdentify.Text = "Identify";
			this.btnIdentify.UseVisualStyleBackColor = true;
			// 
			// txtGroupName
			// 
			this.txtGroupName.Location = new System.Drawing.Point(987, 77);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(188, 20);
			this.txtGroupName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(899, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Group name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(899, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "New User";
			// 
			// txtNewUser
			// 
			this.txtNewUser.Location = new System.Drawing.Point(987, 108);
			this.txtNewUser.Name = "txtNewUser";
			this.txtNewUser.Size = new System.Drawing.Size(157, 20);
			this.txtNewUser.TabIndex = 7;
			// 
			// listUsers
			// 
			this.listUsers.FormattingEnabled = true;
			this.listUsers.Location = new System.Drawing.Point(902, 131);
			this.listUsers.Name = "listUsers";
			this.listUsers.Size = new System.Drawing.Size(276, 290);
			this.listUsers.TabIndex = 9;
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(1150, 107);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(25, 20);
			this.btnAddUser.TabIndex = 6;
			this.btnAddUser.Text = "+";
			this.btnAddUser.UseVisualStyleBackColor = true;
			// 
			// btnCreateGroup
			// 
			this.btnCreateGroup.Location = new System.Drawing.Point(902, 427);
			this.btnCreateGroup.Name = "btnCreateGroup";
			this.btnCreateGroup.Size = new System.Drawing.Size(276, 35);
			this.btnCreateGroup.TabIndex = 6;
			this.btnCreateGroup.Text = "CreateGroup";
			this.btnCreateGroup.UseVisualStyleBackColor = true;
			this.btnCreateGroup.Click += new System.EventHandler(this.btnProcess_Click);
			// 
			// dochazkaControl1
			// 
			this.dochazkaControl1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dochazkaControl1.Location = new System.Drawing.Point(226, 33);
			this.dochazkaControl1.Name = "dochazkaControl1";
			this.dochazkaControl1.Size = new System.Drawing.Size(1136, 683);
			this.dochazkaControl1.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1362, 716);
			this.Controls.Add(this.dochazkaControl1);
			this.Controls.Add(this.listUsers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNewUser);
			this.Controls.Add(this.txtGroupName);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.btnIdentify);
			this.Controls.Add(this.btnTrain);
			this.Controls.Add(this.btnCreateGroup);
			this.Controls.Add(this.btnProcess);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.StopCamera);
			this.Controls.Add(this.OnCamera);
			this.Controls.Add(this.cboCameraDevices);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.optionPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.optionPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel optionPanel;
		private System.Windows.Forms.PictureBox logoBox;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Button domu_btn;
		private System.Windows.Forms.Button nastaveni_btn;
		private System.Windows.Forms.Button dochazka_btn;
		private System.Windows.Forms.Panel SidePanel_blue;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button QnA_btn;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cboCameraDevices;
		private System.Windows.Forms.Button OnCamera;
		private System.Windows.Forms.Button StopCamera;
		private System.Windows.Forms.Button btnProcess;
		private System.Windows.Forms.Button btnTrain;
		private System.Windows.Forms.Button btnIdentify;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNewUser;
		private System.Windows.Forms.ListBox listUsers;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnCreateGroup;
		private DochazkaControl dochazkaControl1;
	}
}

