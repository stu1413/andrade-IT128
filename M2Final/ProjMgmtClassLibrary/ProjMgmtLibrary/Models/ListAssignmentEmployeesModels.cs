using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtDataLibrary.Models
{
    public class ListAssignmentEmployeesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TaskId { get; set; }
        public string Description { get; set; }
        public int AssignmentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
