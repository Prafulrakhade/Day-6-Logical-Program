using System;

namespace ReverseNumber
{
    internal class Program
    {

        public void ReverseNumber()
        {
            int num;
            int rem=0;
            int reverse = 0;
            Console.Write("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            while(num!=0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number : " + reverse);
        }
        static void Main(string[] args)
        {
            Program check = new Program();
            check.ReverseNumber();
        }
    }
}
