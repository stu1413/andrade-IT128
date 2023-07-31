using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtFormsApp.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
        public int RegionId { get; set; }
        public string Phone { get; set; }
        public DateTime DateHired { get; set; }

    }
}
