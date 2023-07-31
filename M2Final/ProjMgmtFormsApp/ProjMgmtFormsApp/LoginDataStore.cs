using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtFormsApp
{
    public class LoginDataStore
    {
        private static LoginDataStore instance = new LoginDataStore();
        int userId;
        string type;
        private LoginDataStore() { }
        public static LoginDataStore Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginDataStore();
                }
                return instance;
            }
        }
        public void setUserId(int userId)
        {
            this.userId = userId;
        }

        public int getUserId()
        {
            return userId;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getType()
        {
            return type;
        }
    }
}
