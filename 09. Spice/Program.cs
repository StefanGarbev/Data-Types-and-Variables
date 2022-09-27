using System;

namespace _09._Spice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int sumOfYield = 0;
            int daysCounter = 0;

            while (startYield >= 100)
            {
                int miniorConsumationOfYield = 26;
                int resultOfYield = startYield - miniorConsumationOfYield;
                
                sumOfYield += resultOfYield;
                daysCounter++;
                startYield -= 10;
                if (startYield < 100)
                {
                    sumOfYield = sumOfYield - miniorConsumationOfYield;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(sumOfYield);
        }
    }
}
