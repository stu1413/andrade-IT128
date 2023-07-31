using ProjMgmtFormsApp.ClientMethods;
using ProjMgmtFormsApp.Models;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace ProjMgmtFormsApp
{
    public partial class Client : Form
    {
        int setUid;

        public Client()
        {
            InitializeComponent();
            LoginDataStore loginDataStore = LoginDataStore.Instance;
            this.setUid = loginDataStore.getUserId();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage responseProjects = client.GetAsync("api/projects").Result;
            HttpResponseMessage responseEmployee = client.GetAsync("api/employees/" + setUid).Result;

            var projects = responseProjects.Content.ReadAsAsync<IList<ListProjectModel>>().Result;
            var employee = responseEmployee.Content.ReadAsAsync<ListEmployeeModel>().Result;

            tboxEmail.Text = employee.Email;
            tboxFullname.Text = employee.LastName + ", " + employee.FirstName;
            tboxPhone.Text = employee.Phone;
            tboxDepartment.Text = employee.Department;
            dataGridView1.DataSource = projects;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/projects").Result;

            var projs = response.Content.ReadAsAsync<IList<ListProjectModel>>().Result;
            dataGridView1.DataSource = projs;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListProjectModel");
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/clients").Result;

            var clnts = response.Content.ReadAsAsync<IList<ListClientModel>>().Result;
            dataGridView1.DataSource = clnts;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListClientModel");
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/employees").Result;

            var emps = response.Content.ReadAsAsync<IList<ListEmployeeModel>>().Result;
            dataGridView1.DataSource = emps;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListEmployeeModel");
        }

        private void btnEmpRoles_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/roles").Result;

            var rles = response.Content.ReadAsAsync<IList<ListRoleModel>>().Result;
            dataGridView1.DataSource = rles;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListRoleModel");
        }

        private void btnEmpDepartments_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/departments").Result;

            var depts = response.Content.ReadAsAsync<IList<ListDepartmentModel>>().Result;
            dataGridView1.DataSource = depts;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListDepartmentModel");
        }

        private void btnEmpInventory_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/employees").Result;

            var emps = response.Content.ReadAsAsync<IList<ListEmployeeModel>>().Result;
            dataGridView1.DataSource = emps;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListEmployeeModel");
        }

        private void btnRegions_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");
            HttpResponseMessage response = client.GetAsync("api/regions").Result;

            var regns = response.Content.ReadAsAsync<IList<ListRegionModel>>().Result;
            dataGridView1.DataSource = regns;

            LoginDataStore loginDataStore = LoginDataStore.Instance;
            loginDataStore.setType("ListRegionModel");
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProject addProject = new AddProject();
            addProject.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRole addRole = new AddRole();
            addRole.Show();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRegion addRegion = new AddRegion();
            addRegion.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void btnEditprofile_Click(object sender, EventArgs e)
        {
            btnEditprofile.Visible = false;
            tboxPhone.Enabled = true;
            tboxPassword.Visible = true;
            tboxPassword.Enabled = true;
            btnEditprofilesubmit.Visible = true;
            btnEditprofilecancel.Visible = true;
        }

        private void btnEditprofilesubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var postData = new EmployeeEdit();
                postData.Password = tboxPassword.Text;
                postData.Phone = tboxPhone.Text;

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7025/api");

                var json = JsonSerializer.Serialize(postData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PutAsync("api/employees/" + setUid + "/edit", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User updated.");
                }
                else
                {
                    MessageBox.Show("Sorry, unsuccessful.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.btnEditprofilecancel_Click(sender, e);

        }

        private void btnEditprofilecancel_Click(object sender, EventArgs e)
        {
            btnEditprofile.Visible = true;
            tboxPhone.Enabled = false;
            tboxPassword.Visible = false;
            tboxPassword.Enabled = false;
            btnEditprofilesubmit.Visible = false;
            btnEditprofilecancel.Visible = false;

            this.Client_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoginDataStore loginDataStore = LoginDataStore.Instance;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                string type = loginDataStore.getType();
                int[] ids = new int[4];
                ids[0] = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString());
                editButton_events(ids, type);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                string type = loginDataStore.getType();
                int[] ids = new int[4];
                ids[0] = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                deleteButton_events(ids, type);
            }

        }

        private void editButton_events(int []ids, string type)
        {
            switch ( type )
            {
                case "ListProjectModel":
                    this.Hide();
                    EditProject editProject = new EditProject(ids);
                    editProject.Show();
                    break;
                case "ListTaskModel":
                    this.Hide();
                    EditTask editTask = new EditTask(ids);
                    editTask.Show();
                    break;
                case "ListAssignmentModel":
                    this.Hide();
                    EditAssignment editAssignment = new EditAssignment(ids);
                    editAssignment.Show();
                    break;
                case "ListClientModel":
                    this.Hide();
                    EditClient editClient = new EditClient(ids);
                    editClient.Show();
                    break;
                case "ListDepartmentModel":
                    this.Hide();
                    EditDepartment editDepartment = new EditDepartment(ids);
                    editDepartment.Show();
                    break;
                case "ListEmployeeModel":
                    this.Hide();
                    EditEmployee editEmployee = new EditEmployee(ids);
                    editEmployee.Show();
                    break;
                case "ListRegionModel":
                    this.Hide();
                    EditRegion editRegion = new EditRegion(ids);
                    editRegion.Show();
                    break;
                case "ListRoleModel":
                    this.Hide();
                    EditRole editRole = new EditRole(ids);
                    editRole.Show();
                    break;
                default:
                    break;
            }
        }


        private void deleteButton_events(int[] ids, string type)
        {
            int id = ids[0];
            int pId = ids[1];
            int tId = ids[2];
            int aId = ids[3];

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            switch ( type )
            {
                case "ListProjectModel":
                    var responseProject = client.DeleteAsync("api/projects/" + pId + "/delete").Result;
                    break;
                case "ListTaskModel":
                    var responseProjectTask = client.DeleteAsync("api/projects/" + pId + "/tasks/" + tId + "/delete").Result;
                    break;
                case "ListAssignmentModel":
                    var responseTaskAssignment = client.DeleteAsync("api/projects/" + pId + "/tasks/" + tId + "/assignments/" + aId + "/delete").Result;
                    break;
                case "ListClientModel":
                    var responseClient = client.DeleteAsync("api/client/" + id + "/delete").Result;
                    break;
                case "ListDepartmentModel":
                    var responseDepartment = client.DeleteAsync("api/departments/" + id + "/delete").Result;
                    break;
                case "ListEmployeeModel":
                    var responseEmployee = client.DeleteAsync("api/employees/" + id + "/delete").Result;
                    break;
                case "ListRegionModel":
                    var responseRegion = client.DeleteAsync("api/regions/" + id + "/delete").Result;
                    break;
                case "ListRoleModel":
                    var responseRole = client.DeleteAsync("api/roles/" + id + "/delete").Result;
                    break;
                default:
                    break;
            }

            this.Hide();
            Client clientForm = new Client();
            clientForm.Show();

        }

    }
}