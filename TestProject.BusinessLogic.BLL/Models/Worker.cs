using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.BLL.Models
{
    public class Worker
    {
        public int WorkerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public WorkerType WorkerType { get; set; }
    }

    // Enum for WorkerType
    public enum WorkerType
    {
        Employee,
        Supervisor,
        Manager
    }
}
