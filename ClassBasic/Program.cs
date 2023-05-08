// See https://aka.ms/new-console-template for more information
using System;

namespace NewClassProgram
{
    internal class Program
    {
        private class Math {
        static public int Abs(int a){
                return 0;
            }
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(Math.Abs(-10));

            ThirdClass abc;
            ABCClass abc2;
            InnerClass inn;
            Console.WriteLine("Hello World!");
        }

        private class InnerClass
        {
        }
    }

    internal class ABCClass
    {
    }
}

