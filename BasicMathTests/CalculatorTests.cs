using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BasicMath;

namespace BasicMathTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)] // Test case 1: 1 + 2 = 3
        [InlineData(-1, -2, -3)] // Test case 2: -1 + -2 = -3
        [InlineData(0, 0, 0)] // Test case 3: 0 + 0 = 0
        [InlineData(int.MaxValue, 1, int.MinValue)] // Test case 4: Overflow scenario
        public void Add_MultipleValues_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Arrange: Create an instance of BasicMaths
            var calculator = new BasicMaths();
            // Act: Call the Add method
            int result = calculator.Add(a, b);
            // Assert: Verify the result
            Xunit.Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)] // Test case 1: 5 - 3 = 2
        [InlineData(-5, -3, -2)] // Test case 2: -5 - -3 = -2
        [InlineData(0, 0, 0)] // Test case 3: 0 - 0 = 0
        [InlineData(int.MinValue, 1, (double)int.MinValue - 1)]

        public void Subtract_MultipleValues_ReturnsCorrectDifference(int a, int b, double expected)
        {
            // Arrange: Create an instance of Calculator
            var calculator = new BasicMaths();
            // Act: Call the Subtract method
            double result = calculator.Subtract(a, b);
            // Assert: Verify the result
            Xunit.Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 6)] // Test case 1: 2 * 3 = 6
        [InlineData(-2, -3, 6)] // Test case 2: -2 * -3 = 6
        [InlineData(0, 5, 0)] // Test case 3: 0 * 5 = 0
        [InlineData(int.MaxValue, 1, (double)int.MaxValue)]

        public void Multiply_MultipleValues_ReturnsCorrectProduct(int a, int b, double expected)
        {
            // Arrange: Create an instance of Calculator
            var calculator = new BasicMaths();
            // Act: Call the Multiply method
            double result = calculator.Multiply(a, b);
            // Assert: Verify the result
            Xunit.Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)] // Test case 1: 6 / 3 = 2
        [InlineData(-6, -3, 2)] // Test case 2: -6 / -3 = 2
        [InlineData(0, 1, 0)] // Test case 3: 0 / 1 = 0
        [InlineData(int.MaxValue, 1, (double)int.MaxValue)]

        public void Divide_MultipleValues_ReturnsCorrectQuotient(int a, int b, double expected)
        {
            // Arrange: Create an instance of BasicMath
            var calculator = new BasicMaths();
            // Act: Call the Divide method
            double result = calculator.Divide(a, b);
            // Assert: Verify the result
            Xunit.Assert.Equal(expected, result);
        }
    }
}
