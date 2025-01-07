using System;

namespace FirstDemo
{
    internal class Hour
    {
        public static void ConvertToS(int hour)
        {
            try
            {
                if (hour < 0)
                {
                    throw new Exception("Hour value cannot be negative.");
                }

                float mins = hour * 60;
                float secs = hour * 3600;

                Console.WriteLine($"{hour} hour/s in mins is: {mins} minutes \n{hour} hour/s in seconds are: {secs} seconds");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}