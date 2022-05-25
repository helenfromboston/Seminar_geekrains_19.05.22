// Задача 62: Заполните спирально массив 4 на 4.

// Комментарий по решению: заполнено последовательно, заполнить через вложенные циклы у меня не получилось.

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

for (j = 0; j < mass.GetLength(1); j++)
{
    mass[i, j] = count + 1;
    count++;
}

j = mass.GetLength(1) - 1;

for (i = 1; i < mass.GetLength(0); i++)
{
    mass[i, j] = count + 1;
    count++;
}

i = mass.GetLength(0) - 1;

for (j = mass.GetLength(1) - 2; j >= 0; j--)
{
    mass[i, j] = count + 1;
    count++;
}

j = 0;

for (i = mass.GetLength(0) - 2; i > 0; i--)
{
    mass[i, j] = count + 1;
    count++;
}

i = 1;

for (j = 1; j < mass.GetLength(1) - 1; j++)
{
    mass[i, j] = count + 1;
    count++;
}

i = 2;

for (j = 2; j > 0; j--)
{
    mass[i, j] = count + 1;
    count++;
}

Print(mass);