using System;
using System.Collections.Generic;
using System.Text;

namespace _30DyasOfCodeHackerRank.Day1_DoubleDownOnDataTypes
{
    class Solution
    {
        static void Main (String[]args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            int a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            string c = Convert.ToString(Console.ReadLine());

            Console.WriteLine(i + a);
            Console.WriteLine((d + b).ToString("#.0"));
            Console.WriteLine(s + c);

            Console.ReadLine();
        }
    }
}
