using System.Diagnostics;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
            Console.WriteLine("first number more then second number");
        else if (num1 < num2)
            Console.WriteLine("first number less then second number");
        else 
        {
            Console.WriteLine("Both number equel");

        }
        Console.ReadKey();


    }
}
