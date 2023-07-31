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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            HttpResponseMessage responseDepartments = client.GetAsync("api/departments").Result;
            HttpResponseMessage responseRoles = client.GetAsync("api/roles").Result;
            HttpResponseMessage responseRegions = client.GetAsync("api/regions").Result;
            var departments = responseDepartments.Content.ReadAsAsync<IList<ListDepartmentModel>>().Result;
            var roles = responseRoles.Content.ReadAsAsync<IList<ListRoleModel>>().Result;
            var regions = responseRegions.Content.ReadAsAsync<IList<ListRegionModel>>().Result;

            cmbDepartment.DataSource = departments.Select(o => o.Id).ToList();
            cmbRole.DataSource = roles.Select(o => o.Id).ToList();
            cmbRegion.DataSource = regions.Select(o => o.Id).ToList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var employeeForm = new EmployeeModel();
            employeeForm.Email = tboxEmail.Text;
            employeeForm.Password = tboxPassword.Text;
            employeeForm.FirstName = tboxFirstname.Text;
            employeeForm.LastName = tboxLastname.Text;
            employeeForm.DepartmentId = (int)cmbDepartment.SelectedItem;
            employeeForm.RoleId = (int)cmbRole.SelectedItem;
            employeeForm.RegionId = (int)cmbRegion.SelectedItem;
            employeeForm.Phone = tboxPhone.Text;
            var json = JsonSerializer.Serialize(employeeForm);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseEmployee = client.PostAsync("api/employees/add", content).Result;

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

        private void cmbDepartment_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseDepartments = client.GetAsync("api/departments").Result;
            var departments = responseDepartments.Content.ReadAsAsync<IList<ListDepartmentModel>>().Result;
            dataGridView1.DataSource = departments;
        }

        private void cmbRole_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseRoles = client.GetAsync("api/roles").Result;
            var roles = responseRoles.Content.ReadAsAsync<IList<ListRoleModel>>().Result;
            dataGridView1.DataSource = roles;
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
