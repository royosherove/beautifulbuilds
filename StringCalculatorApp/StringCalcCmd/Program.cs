using System;
using StringCalc.Lib;

namespace StringCalcCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator sc = new StringCalculator();

            int result = sc.Add(args[0]);

            Console.WriteLine(result);
        }
    }
}
