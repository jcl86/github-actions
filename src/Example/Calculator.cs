using System;
using System.Linq;

namespace Example
{
    public class Calculator
    {
        public int Sum(params int[] numbers) => numbers.Sum();
    }
}
