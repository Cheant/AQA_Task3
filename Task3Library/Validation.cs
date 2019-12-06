using System;

namespace Task3Library
{
    public class Validation
    {
        private int _startRange;
        private int _endRange;

        public int StartRange
        {
            get
            {
                return _startRange;
            }
            private set
            {
                _startRange = value;
            }
        }

        public int EndRange
        {
            get
            {
                return _endRange;
            }
            private set
            {
                _endRange = value;
            }
        }

        public void ValidateEnteredRangeParameters()
        {
            Console.WriteLine("Please enter a non-negative integer for start point of the range:");

            while (!(Int32.TryParse(Console.ReadLine(), out _startRange)) || StartRange < 0)
            {
                Console.WriteLine("Entered value is invalid. Please enter a non-negative integer for start point of the range:");
            }

            Console.WriteLine($"\nPlease enter a non-negative integer for end point of the range (it should be greater than {StartRange + Constants.MinArrayLength - 2}):");

            while (!(Int32.TryParse(Console.ReadLine(), out _endRange)) || (EndRange - StartRange) < (Constants.MinArrayLength - 1))
            {
                Console.WriteLine($"Entered value is invalid. Please enter a non-negative integer for end point of the range (it should be greater than {StartRange + Constants.MinArrayLength - 2}):");
            }
        }
    }
}