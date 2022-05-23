// Задача 62: Заполните спирально массив 4 на 4.

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

int count = 0;
int i = 0;
int j = 0;

for (i = 0; i < mass.GetLength(0); i++)
{
    for (j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = count + 1;
        count++;
        if (j == mass.GetLength(1) - 1)
        {
            for (i = 1; i < mass.GetLength(0); i++)
            {
                mass[i, j] = count + 1;
                count++;
            }
        }
    }
}

Print(mass);