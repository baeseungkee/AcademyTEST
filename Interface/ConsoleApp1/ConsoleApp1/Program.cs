using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Person : iSum
    {
        public int Sum(int a, int b)
        {
            return a + b + 1;
        }
    }

    class Calculator : iSum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
    interface iSum
    {
        int Sum(int a, int b);
    }
}
