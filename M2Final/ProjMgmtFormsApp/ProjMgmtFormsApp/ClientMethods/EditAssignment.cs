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
    public partial class EditAssignment : Form
    {
        int[] ids = new int[4];

        public EditAssignment(int[] ids)
        {
            InitializeComponent();
            this.ids = ids;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var assignmentEdit = new AssignmentEdit();
            int pId = ids[1];
            int tId = ids[2];
            int aId = ids[3];
            assignmentEdit.EmployeeId = cmbEmployee.SelectedIndex;
            assignmentEdit.StartDate = dtpStartDate.Value;
            assignmentEdit.EndDate = dtpEndDate.Value;
            var json = JsonSerializer.Serialize(assignmentEdit);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseTaskAssignment = client.PutAsync("api/projects/" + pId + "/tasks/" + tId + "/assignments/" + aId + "/edit", content).Result;

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
