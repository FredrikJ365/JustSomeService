using src;
using Xunit;

namespace srcTest
{
    public class ProgTest
    {
        [Fact]
        public void GetNumber_return_Two()
        {
            // Arrange
            // Act
            var result = Prog.GetNumber();
            // Assert

            Assert.Equal(1, result);
        }
    }
}
