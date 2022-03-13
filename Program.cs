using System;

namespace PrimeNumber
{
    internal class Program
    {
        public void PrimeNumber()
        {
            int num;
            Console.Write("enter the number = ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(" is not Prime Number ");
                }
                else
                {
                    Console.WriteLine(" is a Prime Number ");
                }
            }
        }
        static void Main(string[] args)
        {
            Program check = new Program();
            check.PrimeNumber();
        }
    }
}
