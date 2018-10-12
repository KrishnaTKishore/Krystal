using System;


namespace Firsttrial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.WriteLine("Enter the value of a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
