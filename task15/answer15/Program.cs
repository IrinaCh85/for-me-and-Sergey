// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {            
        Console.WriteLine("task15");
        Console.Write("Enter number of day of the week ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        CheckingTheDayOfTheWeek(dayNumber);
    }

    private static void CheckingTheDayOfTheWeek(int dayNumber)
    {
        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine("(its a weekend) -> yes");
        }
        else if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("there ia not a day of the week");
        }
        else Console.WriteLine("(it is not a aweekend) -> no");
    }
   
}