// See https://aka.ms/new-console-template for more information



internal class Program
{
    static void Main(string[] args)  
    {
       int num = Convert.ToInt32(Console.ReadLine());
       int res = 1;
       while (res < num)
       {
        Console.WriteLine(res+1);
        res+= 2;
       }
    }
}