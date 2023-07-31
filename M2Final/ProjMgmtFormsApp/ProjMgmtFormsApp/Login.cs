using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using ProjMgmtFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMgmtFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tboxEmail.Text))
            {
                MessageBox.Show("Please enter username");
                return;
            }

            if (String.IsNullOrEmpty(tboxPassword.Text))
            {
                MessageBox.Show("Please enter password");
                return;
            }

            try
            {
                var postData = new UserLogin();
                postData.Email = tboxEmail.Text;
                postData.Password = tboxPassword.Text;

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7025/api");

                var json = JsonSerializer.Serialize(postData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = client.PostAsync("api/Login/login", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var loginData = response.Content.ReadAsAsync<EmployeeModel>().Result;
                    LoginDataStore loginDataStore = LoginDataStore.Instance;
                    loginDataStore.setUserId(loginData.Id);

                    this.Hide();
                    Client clientSession = new Client();
                    clientSession.Show();
                }
                else
                {
                    MessageBox.Show("Username or password doesn't match");
                    tboxPassword.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
