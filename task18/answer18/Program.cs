// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
string[] output = { "x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0" };
int number = Convert.ToInt32(Console.ReadLine());
if (number < 5 && number > 0)
    Console.WriteLine(output[number - 1]);
else
    Console.WriteLine("input incorrect");
