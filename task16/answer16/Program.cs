internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("enter number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter number 2");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int quadro1 = Quadro(num1);
        int quadro2 = Quadro(num2);

        if (quadro1 == num2 || quadro2 == num1)
        {
            Console.Write("yes");
        }
        else
        {
            Console.Write("no");
        }

        int Quadro(int a)
        {
            return a * a;
        }
    }
}