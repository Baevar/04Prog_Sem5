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



// Решение автотеста 3

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//       //Напишите свое решение здесь
//       int[] sumRows = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sumRows[i] = 0;

//             for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     sumRows[i] += array[i,j];
//                 }
//         }
//       return sumRows;
//     }
    
//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//        //Напишите свое решение здесь
//       int indminrow = 0;
//       int minsum = array[0];
//       for (int i = 0 ; i < array.Length; i++)
//       {
//         if(array[i] < minsum)
//         {
//           indminrow = i;
//           minsum = array[i];
//         }
//       }
//       return indminrow;
//     }
//     public static void PrintResult(int[,] numbers)
//     {   
//       int[] resultarray = SumRows(numbers);
//       Console.WriteLine(MinIndex(resultarray));
//       //Напишите свое решение здесь
      
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
            
//             numbers = new int[,] {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//     };      
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }