// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

// Поиск частоты встречаемости конкретного элемента массива
/* int count = 0;
int a = 2;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] == a)
        {
            count++;
        }
    }
} */

Console.WriteLine();

int[] massive = new int[mass.Length];
int[] elcount = new int[massive.Length];

int index = 0;

// Перевод двумерного массива в одномерный
/* for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        massive[index] = mass[i,j];
        index++;
    }
} */

bool exist = false;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        exist = false;
        for (int l = 0; l < index; l++)
        {
            if (massive[l] == mass[i, j])
            {
                exist = true;
                elcount[l]++;
                break;
            }
        }
        if (!exist)
        {
            massive[index] = mass[i, j];
            elcount[index] = 1;
            index++;
        }
    }
}

for (int i = 0; i < index; i++)
{
    Console.WriteLine(massive[i] + " встречается " + elcount[i] + " раз(а)");
}