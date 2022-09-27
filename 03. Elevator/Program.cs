using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int sumofCourses = 0;
            int coursesWithoutReminder = 0;
            int courseswithReminder = 0;

            if (numberOfPeople > capacityOfElevator)
            {
                coursesWithoutReminder = numberOfPeople / capacityOfElevator;
                courseswithReminder = numberOfPeople % capacityOfElevator;
                if (courseswithReminder != 0)
                {
                    sumofCourses = coursesWithoutReminder + 1;
                }
                else
                {
                    sumofCourses = coursesWithoutReminder;
                }
                Console.WriteLine(sumofCourses);
            }
            else if (numberOfPeople < capacityOfElevator)
            {
                sumofCourses +=1;
                Console.WriteLine(sumofCourses); 
            }
            
        }
    }
}
