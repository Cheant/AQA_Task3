using System;
using Task3Library;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();
            validation.GetValidatedValue();

            Calculation calculation = new Calculation(validation.StartRange, validation.EndRange);
            calculation.GetSum();

            Console.ReadKey();
        }
    }
}