
namespace FaceToWork
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
			this.components = new System.ComponentModel.Container();
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
			this.btnIdentify = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.timelbl = new System.Windows.Forms.Label();
			this.timeTxt = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.dateTxt = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.idList = new System.Windows.Forms.ListBox();
			this.cboCameraDevices2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dochazkaControl1 = new FaceToWork.DochazkaControl();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnIdentifyOut = new System.Windows.Forms.Button();
			this.optionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			this.pictureBox1.Location = new System.Drawing.Point(253, 139);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(527, 302);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// cboCameraDevices
			// 
			this.cboCameraDevices.FormattingEnabled = true;
			this.cboCameraDevices.Location = new System.Drawing.Point(363, 446);
			this.cboCameraDevices.Name = "cboCameraDevices";
			this.cboCameraDevices.Size = new System.Drawing.Size(262, 21);
			this.cboCameraDevices.TabIndex = 3;
			// 
			// OnCamera
			// 
			this.OnCamera.Location = new System.Drawing.Point(253, 598);
			this.OnCamera.Name = "OnCamera";
			this.OnCamera.Size = new System.Drawing.Size(262, 53);
			this.OnCamera.TabIndex = 4;
			this.OnCamera.Text = "Zapnout Kamery";
			this.OnCamera.UseVisualStyleBackColor = true;
			this.OnCamera.Click += new System.EventHandler(this.OnCamera_Click);
			// 
			// StopCamera
			// 
			this.StopCamera.Location = new System.Drawing.Point(531, 598);
			this.StopCamera.Name = "StopCamera";
			this.StopCamera.Size = new System.Drawing.Size(262, 53);
			this.StopCamera.TabIndex = 4;
			this.StopCamera.Text = "Vypnout kamery";
			this.StopCamera.UseVisualStyleBackColor = true;
			this.StopCamera.Click += new System.EventHandler(this.StopCamera_Click);
			// 
			// btnIdentify
			// 
			this.btnIdentify.Location = new System.Drawing.Point(645, 446);
			this.btnIdentify.Name = "btnIdentify";
			this.btnIdentify.Size = new System.Drawing.Size(132, 35);
			this.btnIdentify.TabIndex = 6;
			this.btnIdentify.Text = "Identify";
			this.btnIdentify.UseVisualStyleBackColor = true;
			this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(250, 449);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Dostupná zařízení";
			// 
			// timelbl
			// 
			this.timelbl.AutoSize = true;
			this.timelbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.timelbl.Location = new System.Drawing.Point(248, 54);
			this.timelbl.Name = "timelbl";
			this.timelbl.Size = new System.Drawing.Size(52, 25);
			this.timelbl.TabIndex = 12;
			this.timelbl.Text = "Čas :";
			// 
			// timeTxt
			// 
			this.timeTxt.AutoSize = true;
			this.timeTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
			this.timeTxt.Location = new System.Drawing.Point(306, 54);
			this.timeTxt.Name = "timeTxt";
			this.timeTxt.Size = new System.Drawing.Size(20, 25);
			this.timeTxt.TabIndex = 12;
			this.timeTxt.Text = "-";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(249, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 21);
			this.label1.TabIndex = 12;
			this.label1.Text = "Datum";
			// 
			// dateTxt
			// 
			this.dateTxt.AutoSize = true;
			this.dateTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.dateTxt.Location = new System.Drawing.Point(317, 79);
			this.dateTxt.Name = "dateTxt";
			this.dateTxt.Size = new System.Drawing.Size(16, 21);
			this.dateTxt.TabIndex = 12;
			this.dateTxt.Text = "-";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(820, 518);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(197, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Identified person in current image";
			// 
			// idList
			// 
			this.idList.FormattingEnabled = true;
			this.idList.Location = new System.Drawing.Point(823, 534);
			this.idList.Name = "idList";
			this.idList.Size = new System.Drawing.Size(335, 121);
			this.idList.TabIndex = 16;
			// 
			// cboCameraDevices2
			// 
			this.cboCameraDevices2.FormattingEnabled = true;
			this.cboCameraDevices2.Location = new System.Drawing.Point(896, 446);
			this.cboCameraDevices2.Name = "cboCameraDevices2";
			this.cboCameraDevices2.Size = new System.Drawing.Size(262, 21);
			this.cboCameraDevices2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(783, 449);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Dostupná zařízení";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(705, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 30);
			this.label4.TabIndex = 12;
			this.label4.Text = "Vchod";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(1226, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 30);
			this.label6.TabIndex = 12;
			this.label6.Text = "Východ";
			// 
			// dochazkaControl1
			// 
			this.dochazkaControl1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dochazkaControl1.Location = new System.Drawing.Point(226, 36);
			this.dochazkaControl1.Name = "dochazkaControl1";
			this.dochazkaControl1.Size = new System.Drawing.Size(1136, 680);
			this.dochazkaControl1.TabIndex = 10;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(786, 139);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(527, 302);
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// btnIdentifyOut
			// 
			this.btnIdentifyOut.Location = new System.Drawing.Point(1181, 446);
			this.btnIdentifyOut.Name = "btnIdentifyOut";
			this.btnIdentifyOut.Size = new System.Drawing.Size(132, 35);
			this.btnIdentifyOut.TabIndex = 6;
			this.btnIdentifyOut.Text = "Identify";
			this.btnIdentifyOut.UseVisualStyleBackColor = true;
			this.btnIdentifyOut.Click += new System.EventHandler(this.btnIdentifyOut_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1362, 716);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.idList);
			this.Controls.Add(this.dateTxt);
			this.Controls.Add(this.timeTxt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.timelbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnIdentifyOut);
			this.Controls.Add(this.btnIdentify);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.StopCamera);
			this.Controls.Add(this.cboCameraDevices2);
			this.Controls.Add(this.OnCamera);
			this.Controls.Add(this.cboCameraDevices);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dochazkaControl1);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.optionPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Domů";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.optionPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
		private System.Windows.Forms.Button btnIdentify;
		private DochazkaControl dochazkaControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label timelbl;
		private System.Windows.Forms.Label timeTxt;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label dateTxt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox idList;
		private System.Windows.Forms.ComboBox cboCameraDevices2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnIdentifyOut;
	}
}

