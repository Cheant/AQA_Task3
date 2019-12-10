using System;
using Task3Library;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.GetCustomRangeFromConsole();
            calculation.PrintArrayElementsSum();

            Console.ReadKey();
            Console.Clear();
        }
    }
}