using ClassLibrary1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ItShouldReturnZero_WhenEmptyStringProvided()
        {
            // Arrange
            StringCalculator stringCalculator = new();
            int result;
            int expected = 0;

            // Act
            result = stringCalculator.Add("");

            // Assert
            Assert.Equal(expected, result);
        }
    }
}