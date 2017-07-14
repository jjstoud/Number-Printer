using System;
using System.Collections.Generic;

namespace NumberPrinter
{
    static class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            try
            {
                num = Int32.Parse(args[0]);
            }

            catch (Exception e)
            {
                Console.WriteLine("Program experienced an error: " + e.Message);
                Console.WriteLine("Program will continue processing with the max value of a 32-bit signed integer.");
            }

            finally
            {
                if (num == 0)
                {
                    num = Int32.MaxValue;
                }

                List<Tuple<int, string>> pairs = new List<Tuple<int, string>>
                {
                    new Tuple<int, string>(3, "Fizz"),
                    new Tuple<int, string>(5, "Buzz"),
                    new Tuple<int, string>(7, "Bang")
                };

                NumberService.Service.NumberReturn(num, pairs, Console.WriteLine);
                Console.Read();
            }
        }
    }
}
