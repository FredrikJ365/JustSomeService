using System;
using src;
using Xunit;

namespace srcTest
{
    public class ProgTest
    {
        [Fact]
        public void Prod_return_Two()
        {
            // Arrange
            // Act
            var result = Prog.GetNumber();
            // Assert

            Assert.Equal(2, result);
        }
    }
}
