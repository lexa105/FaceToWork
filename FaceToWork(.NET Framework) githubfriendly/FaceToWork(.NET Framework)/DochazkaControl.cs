using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FaceToWork;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace FaceToWork
{
	public partial class DochazkaControl : UserControl
	{
        public DochazkaControl()
		{
			InitializeComponent();
			this.personGroupTBLTableAdapter.Fill(this.dataSet1.PersonGroupTBL);
		}

		private void AddGroupBtn_Click(object sender, EventArgs e)
		{
			FormAddPersonGroup formAddPersonGroup = new FormAddPersonGroup();
			formAddPersonGroup.ShowDialog();
		}

		private void DochazkaControl_Load(object sender, EventArgs e)
		{
			this.personGroupTBLTableAdapter.Fill(this.dataSet1.PersonGroupTBL);
		}

		private void personGroupCmbBox_Click(object sender, EventArgs e)
		{
			this.personGroupTBLTableAdapter.Fill(this.dataSet1.PersonGroupTBL);
		}

		private void DeletePersonGroup_Click(object sender, EventArgs e)
		{
			DeletePersonGroup formDeletePersonGroup = new DeletePersonGroup();
			formDeletePersonGroup.ShowDialog();
		}

		private void AddPerson_Click(object sender, EventArgs e)
		{
			FrmAddPerson formAddPerson = new FrmAddPerson();
			if (personGroupCmbBox.SelectedValue == null)
			{
				MessageBox.Show("You have to select Person Group to add Person !", "Invalid PersonGroup" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}else
			{
				formAddPerson._groupId = personGroupCmbBox.SelectedValue.ToString();
				formAddPerson.GroupName = personGroupCmbBox.Text;
			}
			formAddPerson.ShowDialog();
		}

		private void LoadData_Click(object sender, EventArgs e)
		{
			if (personGroupCmbBox.SelectedValue == null)
			{
				MessageBox.Show("You have to select Person Group !", "Invalid PersonGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				DataSet1TableAdapters.PersonTBLTableAdapter personTBL = new DataSet1TableAdapters.PersonTBLTableAdapter();
				DataTable dt_person = personTBL.GetDataBy1(personGroupCmbBox.SelectedValue.ToString());

				dataGridView1.DataSource = dt_person;

				this.personTBLTableAdapter.Fill(this.dataSet1.PersonTBL);
			}
		}

		private void personGroupCmbBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private async void TrainBtn_Click(object sender, EventArgs e)
		{
			if (personGroupCmbBox.SelectedValue == null)
			{
				MessageBox.Show("You have to select Person Group !", "Invalid PersonGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var faceClient = FaceToWork.Form1.faceClient;
			var _groupId = personGroupCmbBox.SelectedValue.ToString();
			
			try
			{
				await faceClient.PersonGroup.TrainAsync(_groupId);


				while (true)
				{
					await Task.Delay(1000);
					var trainingStatus = await faceClient.PersonGroup.GetTrainingStatusAsync(_groupId);

					if (trainingStatus.Status == TrainingStatusType.Succeeded)
					{
						break;
					}
					await Task.Delay(1000);
				}

				MessageBox.Show("Training successfully completed!", "Training", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
