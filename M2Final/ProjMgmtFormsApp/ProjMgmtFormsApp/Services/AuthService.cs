using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtFormsApp.Services
{
    public partial class AuthService : Component
    {
        public bool IsLoggedIn { get; set; } = false;
        public string RedirectUrl { get; set; } = "post";

        private HttpClient _http;

        public AuthService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> Login(string username, string password)
        {
            var response = await _http.PostAsJsonAsync("https://localhost:7259/api/login/login", new { username, password });
            return await response.Content.ReadAsStringAsync();
        }
    }
}