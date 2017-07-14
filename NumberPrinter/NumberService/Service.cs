using System;
using System.Collections.Generic;

namespace NumberService
{
    public static class Service
    {
        public static bool NumberReturn(int upperBounds, List<Tuple<int, string>> pairs, Action<string> action)
        {
            bool numbersProcessed = false;

            for (var i = 0; i < upperBounds; i++)
            {
                int num = i + 1;
                string line = "";
                bool foundDivisibleNumber = false;

                foreach (var pair in pairs)
                {
                    if (num % pair.Item1 == 0)
                    {
                        if (!foundDivisibleNumber)
                        {
                            foundDivisibleNumber = true;
                        }

                        line = string.Concat(line, pair.Item2);
                    }
                }

                if (!foundDivisibleNumber)
                {
                    line = num.ToString();
                }

                action(line);

                if (num == upperBounds)
                {
                    numbersProcessed = true;
                    break;
                }
            }

            return numbersProcessed;
        }
    }
}