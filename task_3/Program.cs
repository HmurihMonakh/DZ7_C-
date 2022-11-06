/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

доп задача к 7 семинару. Доделать Тетрис в консоли, плюс сделать функцию для генерации случайной фигуры.
*/

Console.WriteLine("введите количество строк");
int NumberString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int NumberCol = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[NumberString, NumberCol];
FillArrayRandomNumbers(numbers);


for (int i = 0; i < numbers.GetLength(1); i++)
{
    double avarage = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / NumberString;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}





