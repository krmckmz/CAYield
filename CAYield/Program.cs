using System;
using System.Collections.Generic;

namespace CAYield
{
    class Program
    {
        static void Main(string[] args)
        {
            //yield 
            /*var numbers = GetNumbers();
            var enumerator = numbers.GetEnumerator();

            while (true)
                if (enumerator.MoveNext())
                    Console.WriteLine(enumerator.Current);
                else
                    break;*/


            /*foreach (var number in numbers)
            {
                Console.Write(numbers);
            }*/


            var oddNumbers = Generator.GetOddNumbers().Take(5);
            var integers = ToList(oddNumbers);
            foreach (var integer in integers)
            {
                Console.WriteLine(integer);
            }

            //var enumerator = oddNumbers.GetEnumerator();

            /* foreach (var odd in oddNumbers)
             {
                 Console.Write(odd);
             }*/
        }
        static List<int> ToList(IEnumerable<int> integers)
        {
            var result = new List<int>();
            var enumerator = result.GetEnumerator();

            while (true)
                if (enumerator.MoveNext())
                    result.Add(enumerator.Current);
                else
                    break;

            return result;
        }
        private static IEnumerable<int> GetNumbers()
        {
            return new List<int>()
            {
                1,2,3,4,5
            };
        }

        public class Generator
        {
            static int counter = 1;
            public static IEnumerable<int> GetOddNumbers()
            {
                while (true)
                {
                    counter++;

                    if (counter % 2 == 1)
                        yield return counter;
                }
            }
        }
    }
}