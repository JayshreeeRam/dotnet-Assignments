namespace DaysWeekEnum
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Sunday = 0,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
          
           Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");
            if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                DaysOfWeek day = (DaysOfWeek)dayNumber;
                Console.WriteLine($"The day of the week is: {day}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
        }
    }
}
