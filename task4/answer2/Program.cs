// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("int first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("int second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("int third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        var arr = new[]{num1,num2,num3};
        int max = 0;
        for (var i = 0; i<arr.Count();i++){
            if (arr[i] > max) 
            {
                max = arr[i];
            }
            
        }
        Console.WriteLine(max);
        
        
        
    }
}