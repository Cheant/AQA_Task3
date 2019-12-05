using System;

namespace Task3Library
{
    public class Validation
    {
        private bool isInt = false;
        private int startRange;
        private int endRange;

        public int StartRange
        {
            get
            {
                return startRange;
            }
            private set
            {
                startRange = value;
            }
        }

        public int EndRange
        {
            get
            {
                return endRange;
            }
            private set
            {
                endRange = value;
            }
        }

        public void GetValidatedValue()
        {
            while (isInt == false || StartRange < 0)
            {
                Console.WriteLine("Please enter a non-negative integer for start point of the range: ");
                isInt = Int32.TryParse(Console.ReadLine(), out startRange);
            }

            isInt = false;

            while (isInt == false || EndRange < 0 || EndRange <= StartRange + 9)
            {
                Console.WriteLine($"Please enter a non-negative integer for end point of the range (it should be greater than {StartRange + 9}): ");
                isInt = Int32.TryParse(Console.ReadLine(), out endRange);
            }
        }
    }
}