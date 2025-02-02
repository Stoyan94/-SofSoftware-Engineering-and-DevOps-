
namespace TownApplication.IntegrationTests
{
    public class TownControllerIntegrationTests
    {
        private readonly TownController _controller;

        public TownControllerIntegrationTests()
        {
            _controller = new TownController();
            _controller.ResetDatabase();
        }

        [Fact]
        public void AddTown_ValidInput_ShouldAddTown()
        {
            // Arrange
            string townName = "Rome"; // Ensure the name is within the valid length
            int population = 2873545;

            // Act
            _controller.AddTown(townName, population);

            // Assert
            var townInDb = _controller.GetTownByName(townName);
            Assert.NotNull(townInDb);
            Assert.Equal(population, townInDb.Population);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("AB")] // Longer than 2 characters
        public void AddTown_InvalidName_ShouldThrowArgumentException(string invalidName)
        {
            // Arrange
            int population = 100000;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => _controller.AddTown(invalidName, population));
            Assert.Equal("Invalid town name.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void AddTown_InvalidPopulation_ShouldThrowArgumentException(int invalidPopulation)
        {
            // Arrange
            string townName = "Athens";

            // Act
            Action act = () => _controller.AddTown(townName, invalidPopulation);

            // Assert
            var exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Population must be a positive number.", exception.Message);
        }

        [Fact]
        public void AddTown_DuplicateTownName_DoesNotAddDuplicateTown()
        {
            // Arrange
            string townName = "SampleTown";
            int population = 10000;

            // Add a town with the same name initially
            _controller.AddTown(townName, population);

            // Act
            _controller.AddTown(townName, population);

            // Assert
            // Check that there is only one town with the specified name
            Assert.Equal(1, _controller.ListTowns().Count);
        }

        [Fact]
        public void UpdateTown_ShouldUpdatePopulation()
        {
            // Arrange
            string townName = "SampleTown";
            int initialPopulation = 10000;
            int updatedPopulation = 12000;

            // Act
            _controller.AddTown(townName, initialPopulation);

            var townToUpdate = _controller.GetTownByName(townName);

            _controller.UpdateTown(townToUpdate.Id, updatedPopulation);

            // Assert
            var townInDb = _controller.GetTownByName(townName);
            Assert.NotNull(townInDb);
            Assert.Equal(updatedPopulation, townInDb.Population);
        }

        [Fact]
        public void DeleteTown_ShouldDeleteTown()
        {
            // Arrange
            string townName = "SampleTown";
            int population = 10000;

            // Act
            _controller.AddTown(townName, population);

            var townToDelete = _controller.GetTownByName(townName);

            _controller.DeleteTown(townToDelete.Id);

            // Assert
            var townInDb = _controller.GetTownByName(townName);
            Assert.Null(townInDb);
        }

        [Fact]
        public void ListTowns_ShouldReturnTowns()
        {
            // Arrange
            _controller.AddTown("Town1", 5000);
            _controller.AddTown("Town2", 8000);
            _controller.AddTown("Town3", 12000);

            // Act
            var townsList = _controller.ListTowns();

            var town1 = _controller.GetTownByName("Town1");
            var town2 = _controller.GetTownByName("Town2");
            var town3 = _controller.GetTownByName("Town3");

            // Assert
            Assert.Equal(3, townsList.Count); // Check if all towns are listed
            Assert.Contains(town1, townsList); // Check if Town1 is listed
            Assert.Contains(town2, townsList); // Check if Town2 is listed
            Assert.Contains(town3, townsList); // Check if Town3 is listed
        }

        [Fact]
        public void PrintAll_ShouldRetrieveAllTowns()
        {
            _controller.AddTown("Berlin", 3000000);
            _controller.AddTown("ssss", 3000000);
            _controller.AddTown("aaaa", 3000000);

            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            _controller.PrintAll();

            // Assert
            var consoleOutput = output.ToString();
            Assert.Contains("Berlin", consoleOutput);
            Assert.Contains("ssss", consoleOutput);
            Assert.Contains("aaaa", consoleOutput);
        }
    }
}
