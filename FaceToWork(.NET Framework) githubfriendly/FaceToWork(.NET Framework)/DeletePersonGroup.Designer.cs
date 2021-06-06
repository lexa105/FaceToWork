
namespace FaceToWork
{
	partial class DeletePersonGroup
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.personGroupTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new FaceToWork.DataSet1();
			this.label1 = new System.Windows.Forms.Label();
			this.personGroupTBLTableAdapter = new FaceToWork.DataSet1TableAdapters.PersonGroupTBLTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personGroupTBLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupID,
            this.groupIdDataGridViewTextBoxColumn1,
            this.groupNameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personGroupTBLBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 66);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(639, 286);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// personGroupTBLBindingSource
			// 
			this.personGroupTBLBindingSource.DataMember = "PersonGroupTBL";
			this.personGroupTBLBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "DELETE";
			// 
			// personGroupTBLTableAdapter
			// 
			this.personGroupTBLTableAdapter.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Dvojklik pro smazání skupiny";
			// 
			// GroupID
			// 
			this.GroupID.DataPropertyName = "GroupID";
			this.GroupID.HeaderText = "ID number";
			this.GroupID.Name = "GroupID";
			this.GroupID.ReadOnly = true;
			// 
			// groupIdDataGridViewTextBoxColumn1
			// 
			this.groupIdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.groupIdDataGridViewTextBoxColumn1.DataPropertyName = "_groupId";
			this.groupIdDataGridViewTextBoxColumn1.HeaderText = "Group ID";
			this.groupIdDataGridViewTextBoxColumn1.Name = "groupIdDataGridViewTextBoxColumn1";
			// 
			// groupNameDataGridViewTextBoxColumn
			// 
			this.groupNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "_groupName";
			this.groupNameDataGridViewTextBoxColumn.HeaderText = "Group Name";
			this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
			// 
			// DeletePersonGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 387);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DeletePersonGroup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DeletePersonGroup";
			this.Load += new System.EventHandler(this.DeletePersonGroup_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personGroupTBLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource personGroupTBLBindingSource;
		private DataSet1TableAdapters.PersonGroupTBLTableAdapter personGroupTBLTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
	}
}