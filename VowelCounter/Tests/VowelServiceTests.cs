using Xunit;
using Xunit.Sdk;

namespace VowelCounter.Tests
{
    public class VowelServiceTests
    {
        [Fact]
        public void VowelService_WhenGivenCorrectString_ReturnsVowelCount()
        {
            // Arrange
            var testString = "abcdefgh ijkl";

            // Act
            var result = VowelService.GetVowelCount(testString);

            // Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void VowelService_WhenGivenNullOrEmptyString_ThrowsArgumentException(string inputString)
        {
            // Act, Arrange, Assert
            Assert.Throws<ArgumentException>(() => VowelService.GetVowelCount(inputString));
        }
    }
}
