using System;
using System.Collections.Generic;
using System.Text;

namespace _30DyasOfCodeHackerRank.Day3_Conquer_Conditionals
{
    class Solution
    {
        static void Main(String[]args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 != 0) Console.WriteLine("Weird");
            else
            {
                if (n < 5) Console.WriteLine("Not Weird");
                else if (n <= 20) Console.WriteLine("Weird");
                else Console.WriteLine("Not Weird");
            }
        }
    }
}
