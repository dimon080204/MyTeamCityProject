namespace MyTeamCityProjectTests
{
    public class Tests
    {
        [Test]
        public void SayHello_ReturnsCorrectGreeting()
        {
            // Arrange
            string name = "John";
            string expected = "Hello, John!";

            // Act
            string result = MyTeamCityProject.Program.SayHello(name);

            // Assert
            Assert.That(result == expected);
        }

        [Test]
        public void CountYourAge_ReturnsCorrectAge()
        {
            // Arrange
            int birthYear = 1990;
            int currentYear = DateTime.Now.Year;
            int expectedAge = currentYear - birthYear;
            // Act
            int result = MyTeamCityProject.Program.CountYourAge(birthYear);
            // Assert
            Assert.That(result == expectedAge);
        }
    }
}
