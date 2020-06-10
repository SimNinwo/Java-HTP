using System;
using System.Net.Http.Headers;

namespace Chapter2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter two numbers.");
            Console.WriteLine("--------------------------");
            
            Console.WriteLine("Enter First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second NUmber: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            int product = firstNumber * secondNumber;
            int difference = firstNumber / secondNumber;
            int quotient = firstNumber % secondNumber;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("RESULTS\n=========");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Modulus: {quotient}");

        }


    }
}
