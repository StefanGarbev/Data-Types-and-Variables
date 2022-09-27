using System;

namespace _07._WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255; //litters
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int addedLittersInTank = int.Parse(Console.ReadLine());
                

                if (sum + addedLittersInTank > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += addedLittersInTank;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
