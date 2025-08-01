using CodingExercise.Models;
using CodingExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodingExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProgramsController : ControllerBase
    {
        private readonly IClientProgramDataService _clientProgramDataService;
        private readonly IProgramTaskDataService _programTaskDataService;

        public ProgramsController(
            IClientProgramDataService clientProgramDataService,
            IProgramTaskDataService programTaskDataService)
        {
            _clientProgramDataService = clientProgramDataService;
            _programTaskDataService = programTaskDataService;
        }

        [HttpGet]
        public async Task<IEnumerable<ClientProgramSummary>> Get()
        {
            // TODO: Implement this method
            // Get all program tasks and all client programs
            // Create a client program summary object for each client program
            // Return the new object

            throw new NotImplementedException();
        }
    }
}
