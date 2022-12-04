// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("task 13 ");
        Console.Write("Enter number:");
            int anyNumber = Convert.ToInt32(Console.ReadLine());
            string anyNumberText = Convert.ToString(anyNumber);
                if (anyNumberText.Length > 2){
                Console.WriteLine("thid number -> " + anyNumberText[2]);
                }
            else {
            Console.WriteLine("-> There is not thid number");
            }
    
        }
}