using CodingExercise.Models;

namespace CodingExercise.Services
{
    public interface IProgramTaskDataService
    {
        Task<List<ProgramTask>> GetAll();
    }
}
