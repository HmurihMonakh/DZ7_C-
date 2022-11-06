
// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо
// значение элемента в двумерном массиве, 
// и возвращает значение либо индекс этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует

Console.WriteLine("введите номер строки");
int NumberString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int NumberCol = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (NumberString > numbers.GetLength(0) || NumberCol > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {NumberString} строки и {NumberCol} столбца равно {numbers[NumberString-1,NumberCol-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}





