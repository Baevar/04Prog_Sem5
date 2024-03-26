// Задача 1: Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Пример
// 4 3 1 (1,2) => 9
// 2 6 9 


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

int numRow = 4;

int numColumn = 2;

int[,] matrix = CreateMatrix(3, 4);

PrintMatrix(matrix);

if (IsExistElement(matrix, numRow, numColumn) == true)
{
    Console.WriteLine(matrix[numRow, numColumn]);
}
else
{
Console.WriteLine("такого элемента нет");
}