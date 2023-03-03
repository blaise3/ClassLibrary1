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

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        [InlineData("4", 4)]
        [InlineData("5", 5)]
        [InlineData("6", 6)]
        public void ItShouldReturnValue_WhenSingleNumberProvided(string input, int expected)
        {
            // Arrange
            StringCalculator stringCalculator = new();
            int result;

            // Act
            result = stringCalculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1,3", 4)]
        [InlineData("2,5", 7)]
        [InlineData("3,6", 9)]
        [InlineData("4,2", 6)]
        [InlineData("5,1", 6)]
        [InlineData("6,3", 9)]
        [InlineData("-6,3", -3)]
        public void ItShouldReturnSumOfValues_WhenTwoNumbersProvided(string input, int expected)
        {
            // Arrange
            StringCalculator stringCalculator = new();
            int result;

            // Act
            result = stringCalculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1\n3", 4)]
        [InlineData("2\n5", 7)]
        [InlineData("3\n6", 9)]
        [InlineData("4\n2", 6)]
        [InlineData("5\n1", 6)]
        [InlineData("6\n3", 9)]
        [InlineData("-6\n3", -3)]
        public void ItShouldReturnSumOfValues_WhenTwoNumbersProvided_WhenSplitIsNevline (string input, int expected)
        {
            // Arrange
            StringCalculator stringCalculator = new();
            int result;

            // Act
            result = stringCalculator.Add(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}