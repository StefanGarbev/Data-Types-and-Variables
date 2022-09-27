using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            uint M = uint.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int targetCounter = 0;
            long delimiterResult = N / 2;

            while (N >= M)
            {
                
                N = N - M;
                if (N == delimiterResult && Y!=0)
                {
                    N = N / Y;
                }
                targetCounter++;
            }
            Console.WriteLine(N);
            Console.WriteLine(targetCounter);
        }
    }
}
