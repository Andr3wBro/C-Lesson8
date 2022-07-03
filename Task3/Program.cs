// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Если функция не VOID как остановить ее выполнение после несоблюдения условия, пробовал все варианты и даже гугл не помог.
// Ошибку выдает но все равно производит вычисления.

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
    Console.WriteLine();
}



int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int aCol = matrixA.GetLength(1); int aRow = matrixA.GetLength(0);
    int bCol = matrixB.GetLength(1); int bRow = matrixB.GetLength(0);
    if (aCol != bRow) Console.WriteLine("Matrix product is not possible");
    int[,] matrixproduct = new int[aRow, bCol];
    {
        for (int i = 0; i < aRow; i++)
        {
            for (int j = 0; j < bCol; j++)
            {
                for (int k = 0; k < aCol; k++)
                {
                    matrixproduct[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixproduct;
    }
}

int[,] marixA = GenerateArray(5, 5, 1, 3);
PrintArray(marixA);
int[,] marixB = GenerateArray(5, 5, 1, 3);
PrintArray(marixB);
PrintArray(MatrixProduct(marixA, marixB));