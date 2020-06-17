using System;
using System.Linq;

namespace Example
{
    public class Calculator
    {
        public int Sum(params int[] numbers) => numbers.Sum();
        public int Multiply(params int[] numbers)
        {
            int result = 1;
            numbers.Select(x =>
            {
                result *= x;
                return x;
            });
            return result;
        }
    }
}
