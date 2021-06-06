
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Dochazka = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
			this.LoadData = new System.Windows.Forms.Button();
			this.personTBLTableAdapter = new FaceToWork.DataSet1TableAdapters.PersonTBLTableAdapter();
			this.TrainBtn = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.GetAttendance = new System.Windows.Forms.Button();
			this.recordTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.recordTBLTableAdapter = new FaceToWork.DataSet1TableAdapters.RecordTBLTableAdapter();
			this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personTBLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personGroupTBLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recordTBLBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Dochazka
			// 
			this.Dochazka.AutoSize = true;
			this.Dochazka.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Dochazka.Location = new System.Drawing.Point(495, 24);
			this.Dochazka.Name = "Dochazka";
			this.Dochazka.Size = new System.Drawing.Size(162, 45);
			this.Dochazka.TabIndex = 0;
			this.Dochazka.Text = "Docházka";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Person Group";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personNameDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personTBLBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(39, 216);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(344, 410);
			this.dataGridView1.TabIndex = 7;
			// 
			// personNameDataGridViewTextBoxColumn
			// 
			this.personNameDataGridViewTextBoxColumn.DataPropertyName = "_personName";
			this.personNameDataGridViewTextBoxColumn.HeaderText = "Person Name";
			this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
			// 
			// groupIdDataGridViewTextBoxColumn
			// 
			this.groupIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "_groupId";
			this.groupIdDataGridViewTextBoxColumn.HeaderText = "GroupID";
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
			this.AddPerson.Location = new System.Drawing.Point(272, 177);
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
			// LoadData
			// 
			this.LoadData.Location = new System.Drawing.Point(39, 177);
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
			this.TrainBtn.Location = new System.Drawing.Point(272, 130);
			this.TrainBtn.Name = "TrainBtn";
			this.TrainBtn.Size = new System.Drawing.Size(111, 33);
			this.TrainBtn.TabIndex = 9;
			this.TrainBtn.Text = "TRAIN";
			this.TrainBtn.UseVisualStyleBackColor = true;
			this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToOrderColumns = true;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATEDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn1,
            this.groupIDDataGridViewTextBoxColumn1,
            this.dateINDataGridViewTextBoxColumn,
            this.dateOUTDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.recordTBLBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(503, 216);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(579, 410);
			this.dataGridView2.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(882, 130);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// GetAttendance
			// 
			this.GetAttendance.Location = new System.Drawing.Point(971, 177);
			this.GetAttendance.Name = "GetAttendance";
			this.GetAttendance.Size = new System.Drawing.Size(111, 33);
			this.GetAttendance.TabIndex = 9;
			this.GetAttendance.Text = "Get Attendance";
			this.GetAttendance.UseVisualStyleBackColor = true;
			this.GetAttendance.Click += new System.EventHandler(this.GetAttendance_Click);
			// 
			// recordTBLBindingSource
			// 
			this.recordTBLBindingSource.DataMember = "RecordTBL";
			this.recordTBLBindingSource.DataSource = this.dataSet1;
			// 
			// recordTBLTableAdapter
			// 
			this.recordTBLTableAdapter.ClearBeforeFill = true;
			// 
			// dATEDataGridViewTextBoxColumn
			// 
			this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
			this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
			this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
			// 
			// personNameDataGridViewTextBoxColumn1
			// 
			this.personNameDataGridViewTextBoxColumn1.DataPropertyName = "PersonName";
			this.personNameDataGridViewTextBoxColumn1.HeaderText = "PersonName";
			this.personNameDataGridViewTextBoxColumn1.Name = "personNameDataGridViewTextBoxColumn1";
			// 
			// groupIDDataGridViewTextBoxColumn1
			// 
			this.groupIDDataGridViewTextBoxColumn1.DataPropertyName = "GroupID";
			this.groupIDDataGridViewTextBoxColumn1.HeaderText = "GroupID";
			this.groupIDDataGridViewTextBoxColumn1.Name = "groupIDDataGridViewTextBoxColumn1";
			// 
			// dateINDataGridViewTextBoxColumn
			// 
			this.dateINDataGridViewTextBoxColumn.DataPropertyName = "DateIN";
			this.dateINDataGridViewTextBoxColumn.HeaderText = "DateIN";
			this.dateINDataGridViewTextBoxColumn.Name = "dateINDataGridViewTextBoxColumn";
			// 
			// dateOUTDataGridViewTextBoxColumn
			// 
			this.dateOUTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dateOUTDataGridViewTextBoxColumn.DataPropertyName = "DateOUT";
			this.dateOUTDataGridViewTextBoxColumn.HeaderText = "DateOUT";
			this.dateOUTDataGridViewTextBoxColumn.Name = "dateOUTDataGridViewTextBoxColumn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(878, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vyberte datum docházky";
			// 
			// DochazkaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.DeletePersonGroup);
			this.Controls.Add(this.GetAttendance);
			this.Controls.Add(this.LoadData);
			this.Controls.Add(this.TrainBtn);
			this.Controls.Add(this.AddPerson);
			this.Controls.Add(this.AddGroupBtn);
			this.Controls.Add(this.personGroupCmbBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Dochazka);
			this.Name = "DochazkaControl";
			this.Size = new System.Drawing.Size(1136, 671);
			this.Load += new System.EventHandler(this.DochazkaControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personTBLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personGroupTBLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recordTBLBindingSource)).EndInit();
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
		private System.Windows.Forms.BindingSource personGroupTBLBindingSource;
		private System.Windows.Forms.Button LoadData;
		private System.Windows.Forms.BindingSource personTBLBindingSource;
		private DataSet1TableAdapters.PersonTBLTableAdapter personTBLTableAdapter;
		private System.Windows.Forms.Button TrainBtn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button GetAttendance;
		private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource recordTBLBindingSource;
		private DataSet1TableAdapters.RecordTBLTableAdapter recordTBLTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateINDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOUTDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label2;
	}
}
