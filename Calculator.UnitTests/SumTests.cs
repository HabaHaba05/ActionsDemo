using Xunit;

namespace Calculator.UnitTests
{
    public class SumTests
    {
        [Fact]
        public void Two_Plus_Two_Should_Return_Four()
        {
            var result = Calculator.Sum(2, 2);
            Assert.Equal(4, result);
        }
    }
}
