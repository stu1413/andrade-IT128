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

namespace ProjMgmtFormsApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseRoles = client.GetAsync("api/roles").Result;
            HttpResponseMessage responseDepts = client.GetAsync("api/departments").Result;
            HttpResponseMessage responseRegns = client.GetAsync("api/regions").Result;

            var roles = responseRoles.Content.ReadAsAsync<IList<ListRoleModel>>().Result;
            var departments = responseDepts.Content.ReadAsAsync<IList<ListDepartmentModel>>().Result;
            var regions = responseRegns.Content.ReadAsAsync<IList<ListRegionModel>>().Result;

            cmbRole.DataSource = roles.Select(o => o.Id).ToList();
            cmbDepartment.DataSource = departments.Select(o => o.Id).ToList();
            cmbRegion.DataSource = regions.Select(o => o.Id).ToList();

        }

        private void btnRegistersubmit_Click(object sender, EventArgs e)
        {
            var postData = new EmployeeModel();
            postData.Email = tboxEmail.Text;
            postData.Password = tboxPassword.Text;
            postData.FirstName = tboxFirstname.Text;
            postData.LastName = tboxLastname.Text;
            postData.DepartmentId = (int)cmbDepartment.SelectedItem;
            postData.RoleId = (int)cmbRole.SelectedItem;
            postData.RegionId = (int)cmbRegion.SelectedItem;
            postData.Phone = tboxPhone.Text;

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/Login/register", content).Result;

            MessageBox.Show("User registered.");

            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void cmbDepartment_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseDepartments = client.GetAsync("api/departments").Result;
            var departments = responseDepartments.Content.ReadAsAsync<IList<ListDepartmentModel>>().Result;
            dataGridView1.DataSource = departments;
        }

        private void cmbRegion_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseRegions = client.GetAsync("api/regions").Result;
            var regions = responseRegions.Content.ReadAsAsync<IList<ListRegionModel>>().Result;
            dataGridView1.DataSource = regions;
        }

        private void cmbRole_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseRoles = client.GetAsync("api/roles").Result;
            var roles = responseRoles.Content.ReadAsAsync<IList<ListRoleModel>>().Result;
            dataGridView1.DataSource = roles;
        }
    }
}
