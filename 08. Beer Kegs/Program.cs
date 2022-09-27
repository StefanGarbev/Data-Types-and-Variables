using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double maxVolume = 0.0;
            string maxKegModel = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                uint kegHeight = uint.Parse(Console.ReadLine());

                double kegVolume = Math.PI * (kegRadius * kegRadius) * kegHeight;
                
                if (maxVolume < kegVolume)
                { 
                    maxVolume = kegVolume;
                    maxKegModel = kegModel;
                }
            }
            Console.WriteLine(maxKegModel);
        }
    }
}
