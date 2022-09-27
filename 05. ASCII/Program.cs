using System;

namespace _05._ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndexofASCII = int.Parse(Console.ReadLine());
            int endIndexofASCII = int.Parse(Console.ReadLine());
            for (int i = startIndexofASCII; i <= endIndexofASCII; i++)
            {
                char symbol = (char)(i);
                Console.Write($"{symbol} ");
            }
        }
    }
}
