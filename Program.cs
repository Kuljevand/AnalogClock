using System;

namespace AnalogClock
{

    class Program
    {

        static void Main(string[] args)
        {
            GetAppInfo();

            
            
            Console.WriteLine("Enter the hours from the clock:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minutes from the clock:");
            int minutes = int.Parse(Console.ReadLine());

            double hoursDegrees = (hours * 30) + (minutes * 30.0 / 60);
            double minuteDegrees = (minutes * 6 );
            double difference = Math.Abs(hoursDegrees - minuteDegrees);

            if (difference > 180)
            {
                difference = 360 - difference;

            }

            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {difference} degrees.");
            Console.ReadKey();


        }//End of a static void

        static void GetAppInfo()
        {
            //set app vars
            string appName = "Degree Calculator";
            string appVersion = "1.0.0";
            string appAuthor = "Dino Kuljevan";
            string appdate = "03/09/22";

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2} {3}", appName, appVersion, appAuthor, appdate);
            Console.ResetColor();

        }// End of a static void
            
    }//End of a class

}//End of a namespace


//Explanation:Program  calculate lesser angle in degrees between hours arrow and minutes arrow and
//provide output in the console window. Each hour on the clock represents an angle of 30 degrees (360 divided by 12).
//Similarly, each minute on the clock will represent an angle of 6 degrees (360 divided by 60)
//and the angle for an hour will increase as the minutes for that hour increases.


