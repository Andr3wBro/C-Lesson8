// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] SelectionSortToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int s = j + 1; s < array.GetLength(1); s++)
            {
                if (array[i, s] > array[i, maxPosition])
                {
                    maxPosition = s;
                }
            }
            int temporary = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temporary;
        }
    }
    return array;
}

int[,] SelectionSortToMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int s = j + 1; s < array.GetLength(1); s++)
            {
                if (array[i, s] < array[i, minPosition])
                {
                    minPosition = s;
                }
            }
            int temporary = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temporary;
        }
    }
    return array;
}

int[,] myar = GenerateArray(5, 10, 1, 10);
PrintArray(myar);

Console.WriteLine("От макс к мин");
PrintArray(SelectionSortToMin(myar));

Console.WriteLine("От мин к макс");
PrintArray(SelectionSortToMax(myar));