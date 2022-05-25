// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Комментарий по решению: в условии не сказано, должен ли быть массив задан случайными числами.
// Поэтому в решении массив последовательно заполняется от 10 до 99.
// Заполнить неповторяющимися числами с использованием рандома у меня не получилось.

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
int value = 10;

if (mass.Length>(99-10))
{
    Console.WriteLine("Трёхмерный массив заданного размера заполнить неповторяющимися двузначными числами невозможно");
}
else
{
    for (int x = 0; x < mass.GetLength(0); x++)
    {
        for (int y = 0; y < mass.GetLength(1); y++)
        {
            for (int z = 0; z < mass.GetLength(2); z++)
            {
                mass[x, y, z] = value;
                value++;
            }
        }
    }
    Print3D(mass);
}