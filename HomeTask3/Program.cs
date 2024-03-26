// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Пример
// 4 3 1 => Строка с индексом 0
// 2 6 9 
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

int MinSumRow(int[,] matrix)           // вычисление номера строки с наименьшей суммой
{
    int minSum = matrix[0,0];
    int numRow = 0;

    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        minSum += matrix[0, j];
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int akk = matrix[i, 0];

        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            akk += matrix[i, j];
        }

        if (minSum > akk)
        {
            numRow = i;
        }
    }
    return numRow;
}

int[,] matrix = CreateMatrix(4, 4);

PrintMatrix(matrix);

int minRow = MinSumRow(matrix);

Console.WriteLine($"Минимальная сумма элементов в строке с индексом {minRow}");