using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofSnowball = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int maxSnow = 0, maxTime = 0, maxQuality = 0; 

            for (int i = 0; i < numberofSnowball; i++)
            { 
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                

                if (snowBallValue > maxValue)
                {
                    maxValue = snowBallValue;
                    maxSnow = snowBallSnow;
                    maxTime = snowBallTime;
                    maxQuality = snowBallQuality;   
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
