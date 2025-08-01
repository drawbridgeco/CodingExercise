namespace CodingExercise.Models
{
    public class ProgramTask
    {
        public int TaskId { get; set; }

        public string Name { get; set; }

        public int ProgramId { get; set; }

        // TODO: Change this to due dates that can have no value
        public DateTime DueDate { get; set; }
    }
}
