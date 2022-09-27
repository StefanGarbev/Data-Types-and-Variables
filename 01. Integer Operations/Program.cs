using System;
using System.Numerics;
namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firsNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());


            BigInteger add = (BigInteger)firsNumber + secondNumber;
            BigInteger devide = add / thirdNumber;
            BigInteger multiply = devide * fourthNumber;

            Console.WriteLine(multiply);
        }
    }
}
