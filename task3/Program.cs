// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних 
// арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1  => [3 3 5]
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

double[] AverageElemRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count += matrix[i, j];
        }
        array[i] = (double)count / matrix.GetLength(1);
    }
    return array;
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);

PrintMatrix(array2d);

double[] resultArray =AverageElemRows(array2d);

for (int i = 0; i < resultArray.Length; i++)
Console.Write($"{Math.Round(resultArray[i],2)}    ");

