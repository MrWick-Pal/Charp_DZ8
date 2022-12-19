// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
int [,] array1 = new int [a, b];
int [,] array2 = new int [a, b];
int [,] matrixMult = new int [a, b];


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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MatrixMultiplication (int [,] arr1 , int [,] arr2)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            matrixMult [i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                matrixMult [i, j] += arr1[i,k] * arr2[k,j];
            }
        }
    }
    PrintMatrix(matrixMult);
}
FillMatrix(array1);
FillMatrix(array2);
PrintMatrix(array1);
Console.WriteLine();
PrintMatrix(array2);
Console.WriteLine();
MatrixMultiplication(array1, array2);