using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num;
            string response;
            Console.WriteLine("Enter a number: ");
            response = Console.ReadLine();
            num = double.Parse(response);
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");
            }
            else
            {
                Console.WriteLine(num + ": is not prime");
            }
        }
        public static bool IsPrime(double number)
        {
            if(number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            //TODO
            return true;
        }
    }
}
