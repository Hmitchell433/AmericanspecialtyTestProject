using Hangfire.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestProject.API.Controllers
{
    [ApiController]
    [Route("api/workers")]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        private readonly ILogger<WorkersController> _logger;

        public WorkersController(IWorkerService workerService, ILogger<WorkersController> logger)
        {
            _workerService = workerService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllWorkers()
        {
            _logger.LogInformation("Fetching all workers.");
            var workers = _workerService.GetAllWorkers();
            return Ok(workers);
        }

        [HttpPost]
        public IActionResult AddWorker(Worker worker)
        {
            _logger.LogInformation("Adding a new worker.");
            _workerService.AddWorker(worker);
            return Ok("Worker added successfully");
        }
    }
}
