internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Clear();
        Console.WriteLine("task10");
        Console.Write("enter tree-digit number: ");
        int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(threeDigitNumber);
        Console.WriteLine("second number of this number-> " + stringNumber[1]);
    }
}