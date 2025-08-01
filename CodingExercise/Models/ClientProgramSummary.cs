namespace CodingExercise.Models
{
    public class ClientProgramSummary
    {
        public ClientProgramSummary()
        {
            Tasks = new List<ProgramTask>();
        }

        public int ProgramId { get; set; }

        public string ProgramName { get; set; }

        public string ProgramUrl { get; set; }

        public List<ProgramTask> Tasks { get; set; }

        /// <summary>
        /// Returns true when any task in the list has a missing due date
        /// </summary>
        public bool HasMissingDueDates
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
