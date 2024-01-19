using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Csaladfa_dolgozat
{
    public partial class csaladfaForm : Form
    {
        public csaladfaForm()
        {
            InitializeComponent();
        }

        private void csaladfaForm_Load(object sender, EventArgs e)
        {
            GetRESTData("http://localhost:3000/family_members");
        }

        private void UpdateJSON(string uri)
        { // Próbálkoztam az Update-el de sajnos nem tudtam működésre bírni
            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(uri);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();
                if ((webResponse.StatusCode == HttpStatusCode.OK) && (webResponse.ContentLength > 0))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<JArray>(s);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void GetRESTData(string uri)
        {

           
            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(uri);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();
                if ((webResponse.StatusCode == HttpStatusCode.OK) && (webResponse.ContentLength > 0))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<JArray>(s);
                    FamilyView.DataSource = arr;
                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FamilyView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] memberData = new string[8];

            if (FamilyView.SelectedRows.Count > 0)
            {

                for (int i = 0; i < 8; i++)
                {
                    memberData[i] = FamilyView.SelectedRows[0].Cells[i].Value + string.Empty;
                }

                nameTextbox.Text = memberData[1];
                dateofbirthTextbox.Text = memberData[2];
                placeofbirthTextbox.Text = memberData[3];
                mothersnameTextbox.Text = memberData[4];
                fathersnameTextbox.Text= memberData[5];
                timeofdeathTextbox.Text = memberData[6];
                placeofdeathTextbox.Text = memberData[7];
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            string[] memberData = new string[7];

            memberData[0] = nameTextbox.Text;
            memberData[1] = dateofbirthTextbox.Text;
            memberData[2] = placeofbirthTextbox.Text;
            memberData[3] = mothersnameTextbox.Text;
            memberData[4] = fathersnameTextbox.Text;
            memberData[5] = timeofdeathTextbox.Text;
            memberData[6] = placeofdeathTextbox.Text;

            FamilyView.SelectedRows[0].Cells[1].Value = memberData[0];
            FamilyView.SelectedRows[0].Cells[2].Value = memberData[1];
            FamilyView.SelectedRows[0].Cells[3].Value = memberData[2];
            FamilyView.SelectedRows[0].Cells[4].Value = memberData[3];
            FamilyView.SelectedRows[0].Cells[5].Value = memberData[4];
            FamilyView.SelectedRows[0].Cells[6].Value = memberData[5];
            FamilyView.SelectedRows[0].Cells[7].Value = memberData[6];

        }
    }
}
