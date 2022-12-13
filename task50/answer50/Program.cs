// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает индекс этого элемента или же указание, что такого элемента нет. Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int rows = ReadInt("enter number of line: ");
int colums = ReadInt("enter number of raw: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> there is not number in array");


// Заполнение массива рандомными числами от 1 до 9
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}