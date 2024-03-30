// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
//  4 3 4 1 => 2 + 3 + 5 = 10
//  2 9 5 4


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

int SumElementMainDiagonal(int[,] matrix)
{
    int sum = 0;

    // for (int i = 1; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 1; j < matrix.GetLength(1); j++)
    //     {
    //         if (i == j)
    //         {
    //             sum += matrix[i, j];
    //         }
    //     }

    // }
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1))
    {
        size = matrix.GetLength(1);
    }
   
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}



int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);

PrintMatrix(array2d);

int result = SumElementMainDiagonal(array2d);

Console.WriteLine($"Сумма элементов на главной диагонали={result}");



