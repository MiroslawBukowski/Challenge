using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChallengeApp
{
    class Program
    {
        //public string? mark;
        //public decimal grade;
        //public static decimal result;
        public static void Main(string[] args)
        {
            string[] names = { "Jan", "Andrzej", "Mirosław", "Wiesław", "Jarosław", "Zbigniew", "Piotr", "Kamila", "Julia", "Anna" };
            int[] ages = { 22, 29, 23, 28, 24, 27, 25, 26, 30, 31 };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Age of {names[i]} is {ages[i]}\n");
            }

        }
    }
}


