// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] mass = new int[4, 4];

FillArray(mass);
Print(mass);
Console.WriteLine();

int save = 0;

if (mass.GetLength(0) != mass.GetLength(1)) // != - не равно (! - отрицание)
{
    Console.WriteLine("Заменить строки на столбцы в данном массиве невозможно");
}
else
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = i; j < mass.GetLength(1); j++)
        {
            save = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = save;
        }
    }
    Print(mass);
}