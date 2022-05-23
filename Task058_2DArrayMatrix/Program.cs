﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
int[,] matrix3 = new int[Math.Max(matrix1.GetLength(0), matrix2.GetLength(0)),
                         Math.Max(matrix1.GetLength(1), matrix2.GetLength(1))];
FillArray(matrix1);
FillArray(matrix2);
Print(matrix1);
Console.WriteLine();
Print(matrix2);
Console.WriteLine();

for (int l = 0; l < matrix3.GetLength(0); l++)
{
    for (int m = 0; m < matrix3.GetLength(1); m++)
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i+l, j+m] += matrix1[i+l, j+m] * matrix2[j+l, i+l];
            }
        }
    }
}

Print(matrix3);

// НЕ РЕШЕНО