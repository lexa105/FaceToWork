using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using FaceToWork;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face;

namespace FaceToWork
{
	public partial class FormAddPersonGroup : Form
	{
		public FormAddPersonGroup()
		{
			InitializeComponent();
		}
		

		private async void AcceptBtn_Click(object sender, EventArgs e)
		{
			var faceClient = FaceToWork.Form1.faceClient;
			var _groupId = groupId_txtBox.Text.ToLower().Replace(" ", "");
						
			try
			{
				await faceClient.PersonGroup.CreateAsync(_groupId, groupName_txtBox.Text); //vytvoří Person Group na Azure Face Api
				DataSet1TableAdapters.PersonGroupTBLTableAdapter personGroupTBL = new DataSet1TableAdapters.PersonGroupTBLTableAdapter();
				personGroupTBL.AddPersonGroup(_groupId, groupName_txtBox.Text);
				Close();
				MessageBox.Show("Group successfully created");

			}
			catch (APIErrorException ex)
			{
				MessageBox.Show(ex.Message);
			}

			
		}
	}
}
