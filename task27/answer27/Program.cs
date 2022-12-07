// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine($"\nTask 27. Enter summary of number");
Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Summary of number: " + sumNumber);
