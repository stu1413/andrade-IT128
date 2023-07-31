using ProjMgmtFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMgmtFormsApp.ClientMethods
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            HttpResponseMessage responseRoles = client.GetAsync("api/roles").Result;
            var regions = responseRoles.Content.ReadAsAsync<IList<ListRegionModel>>().Result;

            cmbRegion.DataSource = regions.Select(o => o.Id).ToList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var clientForm = new ClientForm();
            clientForm.Name = tboxName.Text;
            clientForm.Phone = tboxPhone.Text;
            clientForm.Email = tboxEmail.Text;
            clientForm.RegionId = cmbRegion.SelectedIndex;
            var json = JsonSerializer.Serialize(clientForm);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseClient = client.PostAsync("api/client/add", content).Result;

            this.Hide();
            Client clientForms = new Client();
            clientForms.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client clientForm = new Client();
            clientForm.Show();
        }

        private void cmbRegion_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseRegions = client.GetAsync("api/regions").Result;
            var regions = responseRegions.Content.ReadAsAsync<IList<ListRegionModel>>().Result;
            dataGridView1.DataSource = regions;
        }
    }
}
