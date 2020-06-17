using System;
using System.Linq;

namespace Example
{
    public class Calculator
    {
        public int Sum(params int[] numbers)
        {
            int result = numbers.Aggregate(0, (total, current) => total + current);
            return result;
        }

        public int Multiply(params int[] numbers)
        {
            int result = numbers.Aggregate(1, (total, current) => total * current);
            return result;
        }
    }
}
