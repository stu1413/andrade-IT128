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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            HttpResponseMessage responseClients = client.GetAsync("api/clients").Result;
            HttpResponseMessage responseEmployees = client.GetAsync("api/employees").Result;
            var clients = responseClients.Content.ReadAsAsync<IList<ListClientModel>>().Result;
            var employees = responseEmployees.Content.ReadAsAsync<IList<ListEmployeeModel>>().Result;

            cmbClient.DataSource = clients.Select(o => o.Id).ToList();
            cmbEmployee.DataSource = employees.Select(o => o.Id).ToList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var projectForm = new ProjectForm();
            projectForm.Title = tboxTitle.Text;
            projectForm.Description = tboxDescription.Text;
            projectForm.ClientId = cmbClient.SelectedIndex;
            projectForm.Budget = (float)nupBudget.Value;
            projectForm.EmployeeId = cmbEmployee.SelectedIndex;
            projectForm.StartDate = dtpStartDate.Value;
            projectForm.EndDate = dtpEndDate.Value;
            var json = JsonSerializer.Serialize(projectForm);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseProject = client.PostAsync("api/projects/add", content).Result;

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

        private void cmbClient_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseClients = client.GetAsync("api/clients").Result;
            var clients = responseClients.Content.ReadAsAsync<IList<ListClientModel>>().Result;
            dataGridView1.DataSource = clients;
        }

        private void cmbEmployee_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseEmployees = client.GetAsync("api/employees").Result;
            var employees = responseEmployees.Content.ReadAsAsync<IList<ListEmployeeModel>>().Result;
            dataGridView1.DataSource = employees;
        }
    }
}
