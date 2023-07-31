﻿using ProjMgmtFormsApp.Models;
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
    public partial class EditClient : Form
    {
        int[] ids = new int[4];

        public EditClient(int[] ids)
        {
            InitializeComponent();
            this.ids = ids;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7025/api");

            var clientEdit = new ClientEdit();
            int id = ids[0];
            clientEdit.Phone = tboxPhone.Text;
            clientEdit.Email = tboxEmail.Text;
            var json = JsonSerializer.Serialize(clientEdit);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseClient = client.PutAsync("api/client/" + id + "/edit", content).Result;

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