using System;

namespace Statements_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition1 = false;
            bool condition2 = false;
            bool condition3 = true;

            if (condition1)
            {
                Console.WriteLine("조건 1은 참이여");

            }
            else if (condition2)
            {
                Console.WriteLine("조건 2는 참이여");
            }
            else if (condition3)
            {
                Console.WriteLine("조건 3은 참이여");
            }
            else
            {
                Console.WriteLine("조건 1,2,3이 모두 거짓이여");
            }
        }
    }
}
