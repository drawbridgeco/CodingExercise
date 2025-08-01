using CodingExercise.Models;

namespace CodingExercise.Services
{
    public class ProgramTaskDataService : IProgramTaskDataService
    {
        public Task<List<ProgramTask>> GetAll()
        {
            return Task.FromResult(
                new List<ProgramTask>
                {
                    new ProgramTask
                    {
                        TaskId = 1,
                        Name = "Task 1",
                        ProgramId = 1,
                        DueDate = DateTime.Now.AddDays(1)
                    },
                    new ProgramTask
                    {
                        TaskId = 2,
                        Name = "Task 2",
                        ProgramId = 1,
                        DueDate = DateTime.Now.AddDays(2)
                    },
                    new ProgramTask
                    {
                        TaskId = 3,
                        Name = "Task 3",
                        ProgramId = 2,
                        DueDate = DateTime.Now.AddDays(-5)
                    },
                    new ProgramTask
                    {
                        TaskId = 4,
                        Name = "Task 4",
                        ProgramId = 2,
                        DueDate = DateTime.Now.AddDays(5)
                    }
                });
        }
    }
}
