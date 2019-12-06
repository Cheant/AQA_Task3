using System;

namespace Task3Library
{
    public class Calculation
    {
        public int _sum = 0;
        private int _startArray;
        private int _endArray;
        private int _sizeArray;

        public Calculation(int startValue, int endValue)
        {
            _startArray = startValue;
            _endArray = endValue;
            _sizeArray = _endArray - _startArray + 1;
        }

        private int[] GetGeneratedArray()
        {
            int[] Array = new int[_sizeArray];

            for (int i = 0; i < _sizeArray; i++)
            {
                Array[i] = _startArray;
                _startArray++;
            }
            return Array;
        }

        private int GetArrayElementsSum()
        {
            foreach (int i in GetGeneratedArray())
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    _sum += i;
                }
            }
            return _sum;
        }

        public void PrintArrayElementsSum()
        {
            Console.WriteLine($"\nSum of elements that are divisible by 3, but not divisible by 5: {GetArrayElementsSum()}");
        }
    }
}