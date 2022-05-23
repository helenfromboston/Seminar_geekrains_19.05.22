// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Fill3DArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = new Random().Next(10, 100);
            }
        }
    }
}

void Print3D(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z]} ({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] mass = new int[3, 4, 5];

Fill3DArray(mass);
Print3D(mass);

// НЕ РЕШЕНО