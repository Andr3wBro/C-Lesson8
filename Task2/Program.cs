// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

(int, int) RowWithMinSum(int[,] array)
{
    int[] row = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumofelements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumofelements += array[i, j];
            row[i] = sumofelements;
        }
    }
    int minsumofelements = row[0];
    int rowposition = 0;
    for (int e = 1; e < row.Length; e++)
    {
        if (row[e] < minsumofelements)
        {
            minsumofelements = row[e];
            rowposition = e;
        }
    }
    return (rowposition+1, minsumofelements);
}

int[,] myar = GenerateArray(5, 5, 1, 10);
PrintArray(myar);
(int rowposition, int minsum) = RowWithMinSum(myar);
Console.WriteLine($"The row with the smallest sum of elements => {rowposition}, sum of elements => {minsum}");