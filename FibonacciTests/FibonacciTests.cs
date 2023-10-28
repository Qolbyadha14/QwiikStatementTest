using System;
using Xunit;

namespace FibonacciTests
{
    public class FibonacciTests
    {
        [Fact]
        public void GenerateFibonacci_ShouldPrintCorrectSeries()
        {
            // Arrange
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            Program.GenerateFibonacci(5); // You can change the argument as needed

            // Assert
            var result = consoleOutput.ToString().Trim();
            Assert.Equal("Fibonacci Series:\r\n0  1  1  2  3", result);
        }
    }
}
