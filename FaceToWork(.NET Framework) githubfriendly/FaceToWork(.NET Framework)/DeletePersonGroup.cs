using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using Microsoft.Azure.CognitiveServices.Vision.Face;

using System.Data.SqlClient;

namespace FaceToWork
{
	public partial class DeletePersonGroup : Form
	{
		public DeletePersonGroup()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Data Source=facetoworkdb.database.windows.net;Initial Catalog=AttendanceDB;Persist Security Info=True;User ID=admin01;Password=AcAb@112233");

		private void DeletePersonGroup_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet1.PersonGroupTBL' table. You can move, or remove it, as needed.
			this.personGroupTBLTableAdapter.Fill(this.dataSet1.PersonGroupTBL);
			connection.Open();

		}


		private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			var row = dataGridView1.CurrentRow.Cells[0].Value;
			var rowIndex = dataGridView1.CurrentCell.RowIndex;
			string groupID = dataGridView1.CurrentRow.Cells[1].Value.ToString();

			//variables for faceclient
			var faceClient = FaceToWork.Form1.faceClient;

			//dialog box 
			DialogResult dialog = MessageBox.Show($"Opravdu chcete smazat {groupID}?", "Smazat Person Group", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog == DialogResult.Yes)
			{
			}
			else if (dialog == DialogResult.No)
			{
				return;
			}


			try
			{
				await faceClient.PersonGroup.DeleteAsync(groupID); //vymaze vybranou groupId ve FaceAPI
			}
			catch (APIErrorException apiex)
			{
				MessageBox.Show(apiex.ToString());
			}

			Console.WriteLine(groupID);
			Console.WriteLine(row); //Pro kontrolu v konsoli

			//Query ktere najde v tabulce 
			SqlCommand cmd = new SqlCommand($"DELETE FROM PersonGroupTBL where GroupID = {row}", connection);
			//SqlCommand dltPerson = new SqlCommand($"DELETE FROM PersonTBL  WHERE _groupId Like '{groupID}'", connection);

			cmd.ExecuteNonQuery();
			

			MessageBox.Show("Delete was done");
			dataGridView1.Rows.RemoveAt(rowIndex);
		}

		
	}
}
