// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
void FillMatrix (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
}
void PrintMatrix (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void LowSumInRows (int [,] arr)
{
    int rowSum = 0;
    int tempSum = 0;
    int rowIndex = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        rowSum += arr[0, j];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempSum += arr[i, j];
        }
        if (tempSum < rowSum)
        {
            rowSum = tempSum;
            rowIndex = i;
        }
        tempSum = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {rowIndex + 1}.");
}
int[,] array = new int[4, 4];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine();
LowSumInRows(array);