using FluentAssertions;
using System;
using Xunit;

namespace Example.UnitTests
{
    public class CalculatorShould
    {
        [Fact]
        public void Give_the_same_number_when_only_one_is_provided_to_sum()
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

        [Fact]
        public void Give_the_same_number_when_only_one_is_provided_to_multiply()
        {
            var calculator = new Calculator();

            int result = calculator.Multiply(3);

            result.Should().Be(3);
        }


        [Fact]
        public void Multiply_two_numbers()
        {
            var calculator = new Calculator();

            int result = calculator.Multiply(8, 9);

            result.Should().Be(72);
        }

        [Fact]
        public void Multiply_three_numbers()
        {
            var calculator = new Calculator();

            int result = calculator.Multiply(7, 2, -1);

            result.Should().Be(-14);
        }

        [Fact]
        public void Multiply_four_numbers()
        {
            var calculator = new Calculator();

            int result = calculator.Multiply(3, 6, 2, 10);

            result.Should().Be(360);
        }
    }
}
