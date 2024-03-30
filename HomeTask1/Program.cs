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



// Решение автотеста1:
// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//       int result = array[x-1,y-1];
//       return result;
//     }

// // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//        if (x > array.GetLength(0))
//        {
//           return false;
//        }
//           return true;
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         bool row = ValidatePosition(numbers, x, y);
//         bool column = ValidatePosition(numbers, y, x);
//         if(row == false)
//         {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//         } else if (column == false)
//         {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//         } else
//         {
//           int result = FindElementByPosition(numbers, x, y);
//           Console.WriteLine(result);
//         }
  
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {
           
//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;
            
//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }
