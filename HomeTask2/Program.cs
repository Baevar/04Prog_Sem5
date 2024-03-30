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



// Решение второго автотеста1

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         //Напишите свое решение здесь
//       for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
//     }

// // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         //Напишите свое решение здесь
//     int akk;
      
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         akk = array[0, j];
//         array[0, j] = array[array.GetLength(0)-1, j];
//         array[array.GetLength(0)-1, j] = akk;
//     }
//       return array;
//     }

// // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//        //Напишите свое решение здесь
//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь
//     int[,] result = SwapFirstLastRows(numbers);
//     PrintArray(result);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             }; 
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }