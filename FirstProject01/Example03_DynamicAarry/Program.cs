using System;

namespace Example03_DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArray dynamicArray = new DynamicArray();
            dynamicArray.Add(5);
            dynamicArray.Add(4);
            dynamicArray.Add(3);
            dynamicArray.Add(2);
            dynamicArray.Add(1);
            Console.WriteLine(dynamicArray.Lenght);
            Console.WriteLine(dynamicArray.Capacify);
        }
    }
}
