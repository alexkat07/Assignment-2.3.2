using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal bill = GetValidDecimalInput("How much is your bill?");

            decimal tip = GetValidDecimalInput("How much are you going to tip?");

            decimal total = Calculator(bill, tip);

            Console.WriteLine($"Your total for the evening is ${total}");



            // Method to get valid decimal input from the user
            static decimal GetValidDecimalInput(string prompt)
            {
                decimal value;
                while (true)
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    try
                    {
                        value = Convert.ToDecimal(input);
                        break; // Exit the loop if the input is a valid decimal
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    
                }
                return value;
            }













            static decimal Calculator(decimal bill, decimal tipPercent) 
            {
                bill += bill * tipPercent / 100;
                return bill;
            }
        }
    }
}
