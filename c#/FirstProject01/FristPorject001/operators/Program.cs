using System;

namespace operators
{
    internal class Program
    {


        static int a = 14;
        static int b = 6;
        static int c;

        static void Main(string[] args)
        {



            c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a * b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);

            c = a % b;
            Console.WriteLine(c);
        }
    }
}
