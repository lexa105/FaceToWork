using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FaceToWork_.NET_Framework_;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace FaceToWork_.NET_Framework_
{
	public partial class DochazkaControl : UserControl
	{

        

        public DochazkaControl()
		{
			InitializeComponent();
		}

	    


		private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text == "") return;
            //listUsers.Items.Add(txtNewUser.Text);
        }
/*
        private async void btnCreateGroup_Click(object sender, EventArgs e)
        {
            var fc = FaceToWork_.NET_Framework_.Form1.faceClient;
            if (txtGroupName.Text == "") return;
            try
            {
                _groupId = txtGroupName.Text.ToLower().Replace(" ", "");

                await fc.PersonGroup.CreateAsync(_groupId, txtGroupName.Text);


            }
            catch { }
        }
        */
	}
}
