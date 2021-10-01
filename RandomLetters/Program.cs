using System;
using System.Linq;

namespace RandomLetters
{
   class GenerateRandomLetters
        {
            static void Main(string[] args)
            {
                Console.WriteLine(RandomString(5));
                Console.WriteLine(RandomString(5));
                Console.WriteLine(RandomString(5));
                Console.WriteLine(RandomString(5));
                Console.WriteLine(RandomString(5));
                Console.ReadKey();
            }
            private static Random random = new Random();

       
            public static string RandomString(int length)
            {

                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            }

        }

    }


