using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtFormsApp.Services
{
    public partial class TokenStorageService : Component
    {
        private const string TOKEN_KEY = "auth-token";
        private const string USER_KEY = "auth-user";
        private HttpClient _http;

        public TokenStorageService()
        {
        }

        public void SignOut()
        {
            HttpContext.Current.Session.Clear();
        }

        public void SaveToken(string token)
        {
            HttpContext.Current.Session.Remove(TOKEN_KEY);
            HttpContext.Current.Session.Add(TOKEN_KEY, token);
        }

        public string GetToken()
        {
            return HttpContext.Current.Session[TOKEN_KEY] as string;
        }

        public void SaveUser(int id)
        {
            string strId = id.ToString();
            HttpContext.Current.Session.Remove(USER_KEY);
            HttpContext.Current.Session.Add(USER_KEY, strId);
        }
    }
}