using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtDataLibrary.Models
{
    public class ListAssignmentModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
