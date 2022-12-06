// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("task 19");
Console.Write("Enter number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Your number: {number} - pollindrom.");
  }
  else Console.WriteLine($"Your number: {number} - it is not pollindrom.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"enter right number");


