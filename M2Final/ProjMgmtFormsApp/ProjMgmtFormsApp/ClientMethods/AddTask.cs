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
    public partial class AddTask : Form
    {
        int[] ids = new int[4];

        public AddTask(int[] ids)
        {
            InitializeComponent();
            this.ids = ids;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var taskForm = new TaskForm();
            int pId = ids[1];
            taskForm.ProjectId = pId;
            taskForm.Description = tboxDescription.Text;
            taskForm.BeginDate = dtpBeginDate.Value;
            taskForm.DueDate = dtpDueDate.Value;
            var json = JsonSerializer.Serialize(taskForm);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseProjectTask = client.PostAsync("api/projects/" + pId + "/tasks/add", content).Result;

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
