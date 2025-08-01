using CodingExercise.Controllers;
using CodingExercise.Models;
using CodingExercise.Services;
using FluentAssertions;
using NSubstitute;

namespace CodingExerciseTests.Controllers
{
    public class ProgramsControllerTests
    {
        public class Constructor
        {
            [Fact]
            public void Throws_WhenClientProgramDataServiceIsNull()
            {
                Action act = () => { _ = new ProgramsController(null, new ProgramTaskDataService()); };
                
                // TODO: fix me and add argument name
                act.Should().Throw<ArgumentNullException>();
            }
        }

        public class GetMethod()
        {
            [Fact]
            public async Task ReturnsClientProgramSummary()
            {
                // Implement me
            }
        }
    }
}