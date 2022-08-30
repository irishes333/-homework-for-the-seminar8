// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine($"\nВведите размер массива cтрок x столбцов и диапазон случайных значений массива:");
 int m = InputNumbers("Введите количество строк: ");
 int n = InputNumbers("Введите колличество столбцов: ");
 int range = InputNumbers("Введите диапазон значений массива: от 1 до ");

 int[,] array = new int[m, n]; 
 TwoArray(array);
 WriteArray(array);

 int SumStringElements(int[,] array, int i) 
 {
   int sumString = array[i,0];
   for (int j = 1; j < array.GetLength(1); j++)
   {
     sumString += array[i,j];
   }
   return sumString;
 }

 int minSumString = 0; 
 int sumString = SumStringElements(array, 0);
 for (int i = 1; i < array.GetLength(0); i++)
 {
   int tempSumString = SumStringElements(array, i);
   if (sumString > tempSumString)
   {
     sumString = tempSumString;
     minSumString = i;
   }
 }

   Console.WriteLine($"\n{minSumString+1} - строкa с наименьшей суммой элементов = {sumString} ");

   int InputNumbers(string input) 
 {
   Console.Write(input);
   int output = Convert.ToInt32(Console.ReadLine());
   return output;
 }

 void TwoArray(int[,] array) 
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
         for (int j = 0; j < array.GetLength(1); j++)
     {
       array[i, j] = new Random().Next(range);
     }
   }
 }

 void WriteArray (int[,] array) 
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     {
       Console.Write(array[i,j] + " ");
     }
     Console.WriteLine();
  }
 }
