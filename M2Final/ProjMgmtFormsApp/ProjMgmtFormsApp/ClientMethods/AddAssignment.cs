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
    public partial class AddAssignment : Form
    {
        int[] ids = new int[4];

        public AddAssignment(int[] ids)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var assignmentForm = new AssignmentForm();
            int pId = ids[0];
            int tId = ids[1];
            assignmentForm.TaskId = tId;
            assignmentForm.DepartmentId = cmbDepartment.SelectedIndex;
            assignmentForm.EmployeeId = cmbEmployee.SelectedIndex;
            assignmentForm.StartDate = dtpStartDate.Value;
            assignmentForm.EndDate = dtpStartDate.Value;
            var json = JsonSerializer.Serialize(assignmentForm);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseTaskAssignment = client.PostAsync("api/projects/" + pId + "/tasks/" + tId + "/assignments/add", content).Result;

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
