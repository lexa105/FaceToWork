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
			SqlConnection con = new SqlConnection("Data Source=facetoworkdb.database.windows.net;Initial Catalog=AttendanceDB;Persist Security Info=True;User ID=admin01;Password=AcAb@112233");
			con.Open();
		}
		

		private async void AcceptBtn_Click(object sender, EventArgs e)
		{
			var faceClient = FaceToWork.Form1.faceClient;
			var _groupId = groupId_txtBox.Text.ToLower().Replace(" ", "").ToString();
						
			try
			{
				await faceClient.PersonGroup.CreateAsync(_groupId, groupName_txtBox.Text, recognitionModel: RecognitionModel.Recognition04); //vytvoří Person Group na Azure Face Api

				DataSet1TableAdapters.PersonGroupTBLTableAdapter personGroupTBL = new DataSet1TableAdapters.PersonGroupTBLTableAdapter();
				personGroupTBL.AddPersonGroup(_groupId, groupName_txtBox.Text);// do SQL databaze
				Close();
				MessageBox.Show("Group successfully created");

			}
			catch (APIErrorException ex)
			{
				if(ex.Message == "Operation returned an invalid status code 'Conflict'")
				{
					MessageBox.Show("groupID již existuje zadejte jiné jméno", "groupID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					groupName_txtBox.Clear();
					groupId_txtBox.Clear();
					return;
				}
				
				Console.WriteLine(ex.Message);
			}
			
		}

		private void FormAddPersonGroup_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
		/*	
	private async void AcceptBtn_Click(object sender, EventArgs e)
	{
		var faceClient = FaceToWork.Form1.faceClient;
		var _groupId = groupId_txtBox.Text.ToLower().Replace(" ", "").ToString();
		try
		{
			CreatePersonGroup(faceClient, _groupId, groupName_txtBox.Text);
		}
		catch (APIErrorException ex)
		{
			if (ex.Message == "Operation returned an invalid status code 'Conflict'")
			{
				MessageBox.Show("groupID již existuje zadejte jiné jméno", "groupID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				groupName_txtBox.Clear();
				groupId_txtBox.Clear();
				return;
			}
		}

	}
	public static async Task CreatePersonGroup(IFaceClient faceClient, string _groupId, string groupName)
	{

			await faceClient.PersonGroup.CreateAsync(_groupId, groupName); //vytvoří Person Group na Azure Face Api

			DataSet1TableAdapters.PersonGroupTBLTableAdapter personGroupTBL = new DataSet1TableAdapters.PersonGroupTBLTableAdapter();
			personGroupTBL.AddPersonGroup(_groupId, groupName);// do SQL databaze
			MessageBox.Show("Group successfully created");

	}
*/
	}
}
