// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 200);
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

int[,] mass = new int[4, 10];

FillArray(mass);
Print(mass);
Console.WriteLine();

int min = 0;
int save = 0;
int MinJ = 0;

for (int l = 0; l < mass.GetLength(1); l++)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        min = mass[i, 0];
        for (int j = 0; j < mass.GetLength(1) - l; j++)
        {
            if (mass[i, j] <= min)
            {
                min = mass[i, j];
                MinJ = j;
            }
        }
        save = mass[i, mass.GetLength(1) - 1 - l];
        mass[i, mass.GetLength(1) - 1 - l] = mass[i, MinJ];
        mass[i, MinJ] = save;
    }
} 

Print(mass);