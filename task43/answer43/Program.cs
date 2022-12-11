// See Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
Console.WriteLine("enter value b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter valuek2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"two lines intersect at a point C with coordinates X: {x}, Y: {y}");