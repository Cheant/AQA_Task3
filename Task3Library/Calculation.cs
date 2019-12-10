using System;

namespace Task3Library
{
    public class Calculation
    {
        private int _startValue;
        private int _endValue;

        public void GetCustomRangeFromConsole()
        {
            Console.WriteLine("Please enter a non-negative integer for start point of the range:");

            while (!(Int32.TryParse(Console.ReadLine(), out _startValue)) || _startValue < 0)
            {
                Console.Clear();
                Console.WriteLine("Entered value is invalid. Please enter a non-negative integer for start point of the range:");
            }

            Console.WriteLine($"{Environment.NewLine}Please enter a non-negative integer for end point of the range (it should be greater than {_startValue + Constants.MinArrayLength - 2}):");

            while (!(Int32.TryParse(Console.ReadLine(), out _endValue)) || (_endValue - _startValue) < (Constants.MinArrayLength - 1))
            {
                Console.Clear();
                Console.WriteLine($"Entered value is invalid. Please enter a non-negative integer for end point of the range (it should be greater than {_startValue + Constants.MinArrayLength - 2}):");
            }
        }

        private int[] GetGeneratedArray()
        {
            int[] array = new int[(_endValue - _startValue + 1)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _startValue + i;
            }
            return array;
        }

        private int GetArrayElementsSum()
        {
            int sum = 0;
            foreach (int i in GetGeneratedArray())
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public void PrintArrayElementsSum()
        {
            Console.Clear();
            Console.WriteLine($"Sum of elements that are divisible by 3, but not divisible by 5: {GetArrayElementsSum()}");
        }
    }
}