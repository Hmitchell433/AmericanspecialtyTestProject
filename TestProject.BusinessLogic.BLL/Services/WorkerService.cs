using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BLL.Interface;
using TestProject.BLL.Models;

namespace TestProject.BLL.Services
{
    public class WorkerService : IWorkerService
    {
        private List<Worker> workers = new List<Worker>();

        public IEnumerable<Worker> GetAllWorkers()
        {
            return workers;
        }

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }
    }
}
