using System;

namespace FibonacciSeries
{
    public class Program
    {

        public void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int result;
            int fibo;
            Console.WriteLine("enter the number where Fibonacci Series Till you want : ");
            fibo = int.Parse(Console.ReadLine());
            Console.WriteLine( "0" );
            Console.WriteLine("1");
            for (int i=0;i<fibo;i++)
            {
                result = num1 + num2;
                Console.WriteLine(result+" ");
                num1 = num2;
                num2 = result;
            }

        }

        static void Main(string[] args)
        {
            Program check = new Program();
            check.Fibonacci();
        }
    }
}
