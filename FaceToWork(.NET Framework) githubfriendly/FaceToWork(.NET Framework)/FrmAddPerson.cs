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
using System.IO;

using FaceToWork;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face;


namespace FaceToWork
{
	public partial class FrmAddPerson : Form
	{
		public string _groupId { get; set; } //ziskani _groupID
		public string GroupName { get; set; } //ziskani groupName

		public FrmAddPerson()
		{
			InitializeComponent();

		}

		private void FrmAddPerson_Load(object sender, EventArgs e)
		{
			GroupNameLabel.Text = GroupName.ToString();
		}
		private void btnBrowseFaceFile_Click(object sender, EventArgs e)
		{
			using (var od = new OpenFileDialog())
			{
				od.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
				od.Multiselect = true;
				od.Title = "Add Face images";
				if (od.ShowDialog() == DialogResult.OK)
				{
					foreach (String file in od.FileNames)
					{
						ListFolderPath.Items.Add(file);
					}
				}
			}
		}

		private async void AcceptBtn_Click(object sender, EventArgs e)
		{
			var faceClient = FaceToWork.Form1.faceClient;
			
			
			try
			{
				Person person = await faceClient.PersonGroupPerson.CreateAsync(_groupId, Name_txtBox.Text.ToString());

				DataSet1TableAdapters.PersonTBLTableAdapter personTBL = new DataSet1TableAdapters.PersonTBLTableAdapter();
				personTBL.AddPerson(person.PersonId.ToString(), Name_txtBox.Text, _groupId);

				foreach (string u in ListFolderPath.Items)
				{
					Stream s = File.OpenRead(u);
					
					Console.WriteLine($"Add face to the person ({Name_txtBox.Text}).");
					PersistedFace face = await faceClient.PersonGroupPerson.AddFaceFromStreamAsync(_groupId, person.PersonId, s);
					await Task.Delay(100);

				}

				Close();
				MessageBox.Show("Person successfully added");
			}
			catch (APIErrorException ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
		

		
		
		/*private void Add_Click(object sender, EventArgs e)
		{
			count++;
			y = y + 30;
			TextBox txtFolderFace = new TextBox();
			txtFolderFace.Size = new Size(250, 20);
			txtFolderFace.Location = new Point(54, 370+y);
			Controls.Add(txtFolderFace);
			if (count == 3)
			{
				Add.Enabled = false;
			}
		}
		*/
	}
}
