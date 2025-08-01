using CodingExercise.Models;

namespace CodingExercise.Services
{
    public class ClientProgramDataService : IClientProgramDataService
    {
        public Task<List<ClientProgram>> GetAll()
        {
            return Task.FromResult(new List<ClientProgram>
            {
                new ClientProgram
                {
                    ProgramId = 1,
                    Name = "Program 1",
                    Url = "https://www.google.com"
                },
                new ClientProgram
                {
                    ProgramId = 2,
                    Name = "Program 2",
                    Url = "https://www.bing.com"
                },
                new ClientProgram
                {
                    ProgramId = 3,
                    Name = "Program 3",
                    Url = "https://www.yahoo.com"
                }
            });
        }
    }
}
