int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

// int[,] Create2DrandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue); 
//         }
//     }
//     return newArray;
// }

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] ReverseRows2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int q = 0; q < array.GetLength(1) - j - 1; q++)
//             {
//                 if(array[i, q] < array[i, q + 1])
//                 {
//                     int box = array[i,q];
//                     array[i, q] = array[i, q + 1];
//                     array[i, q + 1] = box;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int rows = Prompt("Input rows value: ");
// int columns = Prompt("Input columns value: ");
// int minValue = Prompt("Input minimal value: ");
// int maxValue = Prompt("Input maximum value: ");

// int[,] newArray = Create2DrandomArray(rows, columns, minValue, maxValue);
// Print2DArray(newArray);
// Console.WriteLine();

// int[,] myArray = ReverseRows2DArray(newArray);
// Print2DArray(myArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int MinimalSumOfRows (int[,] array)
// {
//     int sum = 0;
//     int rows = 0;
//     int minimal = 2147483647;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         Console.WriteLine();
//         Console.Write(sum + " ");

//         if(sum < minimal)
//         {
//             rows = i + 1;
//             minimal = sum;
//         }
//         sum = 0;
//     }
//     return rows;
// }

// int rows = Prompt("Input rows value: ");
// int columns = Prompt("Input columns value: ");
// int minValue = Prompt("Input minimal value: ");
// int maxValue = Prompt("Input maximum value: ");

// int[,] newArray = Create2DrandomArray(rows, columns, minValue, maxValue);
// Print2DArray(newArray);

// int minimalSumOfRows = MinimalSumOfRows(newArray);
// Console.WriteLine();
// Console.WriteLine($"Minimal sum value of rows -> {minimalSumOfRows}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MultiplicationMatrix (int[,] firstMatrix, int[,] secondMatrix)
// {
//     int[,] thirdMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     if(firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
//     {
//         for(int i = 0; i < thirdMatrix.GetLength(0); i++)
//         {
//             for(int j = 0; j < thirdMatrix.GetLength(1); j++)
//             {
//                 thirdMatrix[i, j] = 0;
//                 for(int k = 0; k < firstMatrix.GetLength(1); k++)
//                 {
//                     thirdMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
//                 }
//             }
//         }
//     }
//     Console.WriteLine();
//     return thirdMatrix;
// }

// int rows = Prompt("Input rows value: ");
// int columns = Prompt("Input columns value: ");
// int minValue = Prompt("Input minimal value: ");
// int maxValue = Prompt("Input maximum value: ");

// int[,] firstMatrix = Create2DrandomArray(rows, columns, minValue, maxValue);
// int[,] secondMatrix = Create2DrandomArray(rows, columns, minValue, maxValue);

// Print2DArray(firstMatrix);
// Console.WriteLine();
// Print2DArray(secondMatrix);

// int[,] multipleMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
// Print2DArray(multipleMatrix);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DArray (int rows, int columns, int depth)
// {
//     int[,,] newArray = new int[rows, columns, depth];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             for(int k = 0; k < depth; k++)
//             {
//                 newArray[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
//     return newArray;
// }

// void Print3DArrayWithIndexElement(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int rows = Prompt("Input rows value: ");
// int columns = Prompt("Input columns value: ");
// int depth = Prompt("input depth value: ");

// int[,,] newArray = Create3DArray(rows, columns, depth);
// Print3DArrayWithIndexElement(newArray);

// Как задать именно уникальные не понял. 
// Находил в интернете различные варианты, но что там происходит не понял, поэтому использовать не стал.


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralArray (int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {

        }
    }
}