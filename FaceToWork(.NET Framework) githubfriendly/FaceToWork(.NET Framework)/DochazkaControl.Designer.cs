
namespace FaceToWork
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
			this.components = new System.ComponentModel.Container();
			this.Dochazka = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new FaceToWork.DataSet1();
			this.personGroupCmbBox = new System.Windows.Forms.ComboBox();
			this.personGroupTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AddGroupBtn = new System.Windows.Forms.Button();
			this.DeletePersonGroup = new System.Windows.Forms.Button();
			this.AddPerson = new System.Windows.Forms.Button();
			this.personGroupTBLTableAdapter = new FaceToWork.DataSet1TableAdapters.PersonGroupTBLTableAdapter();
			this.CamIN = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.LoadData = new System.Windows.Forms.Button();
			this.personTBLTableAdapter = new FaceToWork.DataSet1TableAdapters.PersonTBLTableAdapter();
			this.TrainBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personTBLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personGroupTBLBindingSource)).BeginInit();
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
			this.label1.Location = new System.Drawing.Point(35, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Person Group";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personTBLBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(39, 216);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(461, 410);
			this.dataGridView1.TabIndex = 7;
			// 
			// personIdDataGridViewTextBoxColumn
			// 
			this.personIdDataGridViewTextBoxColumn.DataPropertyName = "_personId";
			this.personIdDataGridViewTextBoxColumn.HeaderText = "_personId";
			this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
			// 
			// personNameDataGridViewTextBoxColumn
			// 
			this.personNameDataGridViewTextBoxColumn.DataPropertyName = "_personName";
			this.personNameDataGridViewTextBoxColumn.HeaderText = "_personName";
			this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
			// 
			// groupIdDataGridViewTextBoxColumn
			// 
			this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "_groupId";
			this.groupIdDataGridViewTextBoxColumn.HeaderText = "_groupId";
			this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
			// 
			// personTBLBindingSource
			// 
			this.personTBLBindingSource.DataMember = "PersonTBL";
			this.personTBLBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// personGroupCmbBox
			// 
			this.personGroupCmbBox.DataSource = this.personGroupTBLBindingSource;
			this.personGroupCmbBox.DisplayMember = "_groupName";
			this.personGroupCmbBox.FormattingEnabled = true;
			this.personGroupCmbBox.IntegralHeight = false;
			this.personGroupCmbBox.Location = new System.Drawing.Point(39, 98);
			this.personGroupCmbBox.Name = "personGroupCmbBox";
			this.personGroupCmbBox.Size = new System.Drawing.Size(227, 21);
			this.personGroupCmbBox.TabIndex = 8;
			this.personGroupCmbBox.ValueMember = "_groupId";
			this.personGroupCmbBox.SelectedIndexChanged += new System.EventHandler(this.personGroupCmbBox_SelectedIndexChanged);
			this.personGroupCmbBox.Click += new System.EventHandler(this.personGroupCmbBox_Click);
			// 
			// personGroupTBLBindingSource
			// 
			this.personGroupTBLBindingSource.DataMember = "PersonGroupTBL";
			this.personGroupTBLBindingSource.DataSource = this.dataSet1;
			// 
			// AddGroupBtn
			// 
			this.AddGroupBtn.Location = new System.Drawing.Point(272, 91);
			this.AddGroupBtn.Name = "AddGroupBtn";
			this.AddGroupBtn.Size = new System.Drawing.Size(111, 33);
			this.AddGroupBtn.TabIndex = 9;
			this.AddGroupBtn.Text = "Add PersonGroup";
			this.AddGroupBtn.UseVisualStyleBackColor = true;
			this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
			// 
			// DeletePersonGroup
			// 
			this.DeletePersonGroup.Location = new System.Drawing.Point(389, 91);
			this.DeletePersonGroup.Name = "DeletePersonGroup";
			this.DeletePersonGroup.Size = new System.Drawing.Size(111, 33);
			this.DeletePersonGroup.TabIndex = 9;
			this.DeletePersonGroup.Text = "Delete PersonGroup";
			this.DeletePersonGroup.UseVisualStyleBackColor = true;
			this.DeletePersonGroup.Click += new System.EventHandler(this.DeletePersonGroup_Click);
			// 
			// AddPerson
			// 
			this.AddPerson.Location = new System.Drawing.Point(39, 177);
			this.AddPerson.Name = "AddPerson";
			this.AddPerson.Size = new System.Drawing.Size(111, 33);
			this.AddPerson.TabIndex = 9;
			this.AddPerson.Text = "Add Person";
			this.AddPerson.UseVisualStyleBackColor = true;
			this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
			// 
			// personGroupTBLTableAdapter
			// 
			this.personGroupTBLTableAdapter.ClearBeforeFill = true;
			// 
			// CamIN
			// 
			this.CamIN.Location = new System.Drawing.Point(574, 606);
			this.CamIN.Name = "CamIN";
			this.CamIN.Size = new System.Drawing.Size(116, 52);
			this.CamIN.TabIndex = 10;
			this.CamIN.Text = "Camera IN";
			this.CamIN.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(707, 606);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 52);
			this.button2.TabIndex = 10;
			this.button2.Text = "Camera OUT";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// LoadData
			// 
			this.LoadData.Location = new System.Drawing.Point(389, 177);
			this.LoadData.Name = "LoadData";
			this.LoadData.Size = new System.Drawing.Size(111, 33);
			this.LoadData.TabIndex = 9;
			this.LoadData.Text = "Load Data";
			this.LoadData.UseVisualStyleBackColor = true;
			this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
			// 
			// personTBLTableAdapter
			// 
			this.personTBLTableAdapter.ClearBeforeFill = true;
			// 
			// TrainBtn
			// 
			this.TrainBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TrainBtn.Location = new System.Drawing.Point(389, 130);
			this.TrainBtn.Name = "TrainBtn";
			this.TrainBtn.Size = new System.Drawing.Size(111, 33);
			this.TrainBtn.TabIndex = 9;
			this.TrainBtn.Text = "TRAIN";
			this.TrainBtn.UseVisualStyleBackColor = true;
			this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
			// 
			// DochazkaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.CamIN);
			this.Controls.Add(this.DeletePersonGroup);
			this.Controls.Add(this.LoadData);
			this.Controls.Add(this.TrainBtn);
			this.Controls.Add(this.AddPerson);
			this.Controls.Add(this.AddGroupBtn);
			this.Controls.Add(this.personGroupCmbBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Dochazka);
			this.Name = "DochazkaControl";
			this.Size = new System.Drawing.Size(1136, 671);
			this.Load += new System.EventHandler(this.DochazkaControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personTBLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personGroupTBLBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Dochazka;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox personGroupCmbBox;
		private System.Windows.Forms.Button AddGroupBtn;
		private DataSet1 dataSet1;
		private System.Windows.Forms.Button DeletePersonGroup;
		private System.Windows.Forms.Button AddPerson;
		private DataSet1TableAdapters.PersonGroupTBLTableAdapter personGroupTBLTableAdapter;
		private System.Windows.Forms.Button CamIN;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource personGroupTBLBindingSource;
		private System.Windows.Forms.Button LoadData;
		private System.Windows.Forms.BindingSource personTBLBindingSource;
		private DataSet1TableAdapters.PersonTBLTableAdapter personTBLTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button TrainBtn;
	}
}
