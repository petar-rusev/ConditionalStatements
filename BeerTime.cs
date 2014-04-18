using System;
using System.Globalization;

class BeerTime
{

    static void Main()
    {
        Console.WriteLine("Please enter an exact time in format: (h:mm:AM or PM)");
        TimeSpan startTime = TimeSpan.Parse("13:00");
        TimeSpan endTime = TimeSpan.Parse("3:00");
        try
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", null);
            if (TimeSpan.Compare(time - time.Date, startTime) == 1 || TimeSpan.Compare(time - time.Date, startTime) == 0 || TimeSpan.Compare(time - time.Date, endTime) == -1)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non beer time");
            }
        }
        catch
        {
            Console.WriteLine("invalid time");
        }
    }
}
