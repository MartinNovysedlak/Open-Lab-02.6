using System;

namespace test
{
    class Program
    {
        public static bool five(int number)
        {
            return number % 100 == 0;
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(five(number));
        }
    }
}
