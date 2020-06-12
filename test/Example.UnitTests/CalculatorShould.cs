using FluentAssertions;
using System;
using Xunit;

namespace Example.UnitTests
{
    public class CalculatorShould
    {
        [Fact]
        public void Give_the_same_number_when_only_one_is_provided()
        {
            var calculator = new Calculator();

            int result = calculator.Sum(7);

            result.Should().Be(7);
        }

        [Fact]
        public void Sum_two_numbers()
        {
            var calculator = new Calculator();

            int result = calculator.Sum(2, 3);

            result.Should().Be(5);
        }

        [Fact]
        public void Sum_three_numbers()
        {
            var calculator = new Calculator();

            int result = calculator.Sum(7, 2, -1);

            result.Should().Be(8);
        }
    }
}
