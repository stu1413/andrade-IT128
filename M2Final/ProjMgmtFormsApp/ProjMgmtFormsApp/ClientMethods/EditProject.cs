using ProjMgmtFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMgmtFormsApp.ClientMethods
{
    public partial class EditProject : Form
    {
        int[] ids = new int[4];

        public EditProject(int[] ids)
        {
            InitializeComponent();
            this.ids = ids;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var projectEdit = new ProjectEdit();
            int pId = ids[0];
            projectEdit.Title = tboxTitle.Text;
            projectEdit.Description = tboxDescription.Text;
            projectEdit.Budget = (float)nupBudget.Value;
            var json = JsonSerializer.Serialize(projectEdit);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseProject = client.PutAsync("api/projects/" + pId + "/edit", content).Result;

            this.Hide();
            Client clientForm = new Client();
            clientForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client clientForm = new Client();
            clientForm.Show();
        }
    }
}
