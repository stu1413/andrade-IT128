using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMgmtFormsApp.Models
{
    public class TaskForm
    {
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime DueDate { get; set; }

    }
}
