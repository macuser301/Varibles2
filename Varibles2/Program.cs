using System;

namespace Varibles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string customer1 = "Rob";
            int customerAge = 42;
            Char character2 = 'B';
            bool answer1 = true;
            decimal exactBalance = 11525.50m;
            double myBalance = 11000.00;

            Console.WriteLine($"My customer's name is {customer1}, He is {customerAge},years old. He has around {myBalance} in cash.");
            Console.WriteLine($"{customer1} told me his total balance in savings is {exactBalance}.");
            Console.WriteLine($"In a new video game im playing, a Character {character2} is supporting character in game.");
        }   
    }
}