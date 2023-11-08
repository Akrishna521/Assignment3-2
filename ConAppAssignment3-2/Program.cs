using System;

namespace DataTypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Convert string to integer using TryParse
            string inputString = "123";
            int parsedInt;
            bool parseSuccess = int.TryParse(inputString, out parsedInt);

            if (parseSuccess)
            {
                Console.WriteLine($"Successfully converted '{inputString}' to integer: {parsedInt}");
            }
            else
            {
                Console.WriteLine($"Failed to convert '{inputString}' to integer.");
            }

            // Example 2: Convert string to DateTime using Convert
            string dateString = "2023-11-08";
            DateTime parsedDate;

            try
            {
                parsedDate = DateTime.Parse(dateString);
                Console.WriteLine($"Successfully converted '{dateString}' to DateTime: {parsedDate}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Failed to convert '{dateString}' to DateTime due to invalid format.");
            }

            // Example 3: Convert string to TimeSpan using Parse
            string timeString = "01:20:30";
            TimeSpan parsedTimeSpan;

            try
            {
                parsedTimeSpan = TimeSpan.Parse(timeString);
                Console.WriteLine($"Successfully converted '{timeString}' to TimeSpan: {parsedTimeSpan}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Failed to convert '{timeString}' to TimeSpan due to invalid format.");
            }
        }
    }
}