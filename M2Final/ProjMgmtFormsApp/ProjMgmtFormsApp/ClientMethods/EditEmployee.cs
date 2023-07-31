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
    public partial class EditEmployee : Form
    {
        int[] ids = new int[4];

        public EditEmployee(int[] ids)
        {
            InitializeComponent();
            this.ids = ids;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var employeeEdit = new EmployeeEdit();
            int id = ids[0];
            employeeEdit.Password = tboxPassword.Text;
            employeeEdit.Phone = tboxPhone.Text;
            var json = JsonSerializer.Serialize(employeeEdit);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseEmployee = client.PutAsync("api/employees/" + id + "/edit", content).Result;

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
