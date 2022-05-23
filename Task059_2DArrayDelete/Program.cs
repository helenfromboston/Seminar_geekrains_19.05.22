// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

int[,] mass = new int[4, 4];

FillArray(mass);
Print(mass);
Console.WriteLine();

int min = mass[0, 0];
int MinI = 0;
int MinJ = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < min)
        {
            min = mass[i, j];
            MinI = i;
            MinJ = j;
        }
    }
}

Console.WriteLine(min + " " + MinI + " " + MinJ);
Console.WriteLine();

int[,] massive = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];

int l = 0;
int m = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i > MinI)
        {
            l = i - 1;
        }
        else
        {
            l = i;
        }
        if (j > MinJ)
        {
            m = j - 1;
        }
        else
        {
            m = j;
        }
        massive[l, m] = mass[i, j];
    }
}

Print(massive);