using CodingExercise.Models;

namespace CodingExercise.Services
{
    public interface IClientProgramDataService
    {
        Task<List<ClientProgram>> GetAll();
    }
}