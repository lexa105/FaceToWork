
namespace FaceToWork_.NET_Framework_
{
	partial class DochazkaControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Dochazka = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNewUser = new System.Windows.Forms.TextBox();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Dochazka
			// 
			this.Dochazka.AutoSize = true;
			this.Dochazka.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Dochazka.Location = new System.Drawing.Point(31, 11);
			this.Dochazka.Name = "Dochazka";
			this.Dochazka.Size = new System.Drawing.Size(162, 45);
			this.Dochazka.TabIndex = 0;
			this.Dochazka.Text = "Docházka";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(32, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Zaměstnanci";
			// 
			// btnAddUser
			// 
			this.btnAddUser.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Location = new System.Drawing.Point(283, 117);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(91, 45);
			this.btnAddUser.TabIndex = 4;
			this.btnAddUser.Text = "+";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(36, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "New User";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(36, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Group Name";
			// 
			// txtNewUser
			// 
			this.txtNewUser.Location = new System.Drawing.Point(120, 116);
			this.txtNewUser.Name = "txtNewUser";
			this.txtNewUser.Size = new System.Drawing.Size(157, 20);
			this.txtNewUser.TabIndex = 6;
			// 
			// txtGroupName
			// 
			this.txtGroupName.Location = new System.Drawing.Point(120, 142);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.Size = new System.Drawing.Size(157, 20);
			this.txtGroupName.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(37, 208);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(337, 426);
			this.dataGridView1.TabIndex = 7;
			// 
			// DochazkaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtGroupName);
			this.Controls.Add(this.txtNewUser);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Dochazka);
			this.Name = "DochazkaControl";
			this.Size = new System.Drawing.Size(1136, 671);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Dochazka;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNewUser;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
