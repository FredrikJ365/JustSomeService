using src.Models;
using Xunit;

namespace srcTest
{
    public class NumberViewModelTest
    {
        [Fact]
        public void RandomUnsignedByteNumber_return_0To256()
        {
            // Arrange
            var model = new NumberViewModel();

            // Act
            var result = model.RandomNumber;
            
            // Assert
            Assert.InRange(result, 0, 256);
        }
    }
}
