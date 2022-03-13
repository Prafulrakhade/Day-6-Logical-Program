using System;

namespace PerfectNumber
{
    internal class Program
    {
        public void perfectNumber()
        {
            int num;
            int sum = 0;
            Console.Write("Enter the number = ");
            num = int.Parse(Console.ReadLine());
            for(int i=1; i<num; i++)
            {
                if(num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum==num)
            {
                Console.WriteLine(num+" is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num+" is not a Perfect Number");
            }
        }
        static void Main(string[] args)
        {
            Program check = new Program();
            check.perfectNumber();
        }
    }
}
