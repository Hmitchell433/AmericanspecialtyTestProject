using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BLL.Models;

namespace TestProject.BLL.Interface
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetAllWorkers();
        void AddWorker(Worker worker);
    }
}
