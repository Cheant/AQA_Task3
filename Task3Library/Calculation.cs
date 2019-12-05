using System;

namespace Task3Library
{
    public class Calculation
    {
        public int Sum = 0;
        private int startArray;
        private int endArray;
        private int sizeArray;

        public Calculation(int startValue, int endValue)
        {
            startArray = startValue;
            endArray = endValue;
        }

        public void GetSum()
        {
            sizeArray = endArray - startArray + 1;
            int[] Array = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Array[i] = startArray;
                startArray++;
            }

            foreach (int i in Array)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Sum += i;
                }
            }

            Console.WriteLine($"Sum: {Sum}");
        }
    }
}