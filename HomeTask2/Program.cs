// Задача 2: Задайте двумерный массив. Напишите 
// программу, которая поменяет местами первую и 
// последнюю строку массива.


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

bool IsExistElement(int[,] matrix, int row, int columns)               // проверяю, существует ли элемент
{
    if (row < matrix.GetLength(0) && columns < matrix.GetLength(1))
    {
        return true;
    }
    return false;
}

int[,] SwapRows(int[,] matrix, int row1, int row2)          // меняю строки местами
{
    int akk;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        akk = matrix[row1, j];
        matrix[row1, j] = matrix[row2, j];
        matrix[row2, j] = akk;
    }
    return matrix;
}

int[,] matrix = CreateMatrix(4, 4);

PrintMatrix(matrix);

int[,] swapRowMatrix = SwapRows(matrix, 1, 3);

Console.WriteLine();

PrintMatrix(swapRowMatrix);