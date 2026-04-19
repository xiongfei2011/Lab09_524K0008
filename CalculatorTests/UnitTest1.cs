using Xunit;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Fact]
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(0, 0, 0)]
        public void Test1()
        {
            var calc = new Calculator();
            int result = calc.Add(a, b);
            Assert.Equal(expected, result);
        }
    }
}