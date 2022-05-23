// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int[,] mass = new int[4, 3];

FillArray(mass);
Print(mass);

Console.WriteLine();

int save = 0;

for (int j = 0; j < mass.GetLength(1); j++) // mass.GetLength(1) - кол-во столбцов / длина строки
{
    save = mass[0, j];
    mass[0,j] = mass[mass.GetLength(0) - 1, j]; // mass.GetLength(0) - кол-во строк / высота столбца
    mass[mass.GetLength(0) - 1, j] = save;
}

Print(mass);