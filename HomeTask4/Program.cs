// Задача 4*(не обязательная): Задайте двумерный массив 
// из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен 
// наименьший элемент массива. Под удалением 
// понимается создание нового двумерного массива без 
// строки и столбца

// 4 3 1 => 2 6
// 2 6 9    4 6
// 4 6 2

int[,] CreateMatrix(int RowsLength, int ColumnsLength)  // создание матрицы
{
    int[,] matrix = new int[RowsLength, ColumnsLength];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;

}

void PrintMatrix(int[,] matrix)                     // вывод матрицы на печать
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[] FindPosMinElement(int[,] matrix)              // Вычисляю позицию наименьшего элемента
{
    int[] posMinEl = [0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[posMinEl[0], posMinEl[1]])
            {
                posMinEl[0] = i;
                posMinEl[1] = j;
            }
        }
    }
    return posMinEl;
}

int[,] ResultMatrix(int[,] matrix, int[] posMinEl)  // удаление из матрицы столбца и строки с минимальным элементом
{

    int[,] matrixMinusRow = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];

    for (int i = 0; i < posMinEl[0]; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixMinusRow[i, j] = matrix[i, j];
        }
    }


    for (int i = posMinEl[0]; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixMinusRow[i, j] = matrix[i + 1, j];
        }
    }

    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < posMinEl[1]; j++)
        {
            resultMatrix[i, j] = matrixMinusRow[i, j];
        }
    }


    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = posMinEl[1]; j < matrix.GetLength(1) - 1; j++)
        {
            resultMatrix[i, j] = matrixMinusRow[i, j + 1];
        }
    }
    return resultMatrix;
}

int[,] matrix = CreateMatrix(4, 4);

PrintMatrix(matrix);

int[] posMinEl = FindPosMinElement(matrix);

int[,] resultMatrix = ResultMatrix(matrix, posMinEl);

Console.WriteLine();

PrintMatrix(resultMatrix);

