// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите x - первую размерность массива");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y - вторую размерность массива");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z - третью размерность массива");
int z = Convert.ToInt32(Console.ReadLine());

if (x < 1 || y < 1 || z < 1 || x * y * z > 180) 
{
    Console.WriteLine("Некорректные значения");
}
else
{
    int[,,] matrix3 = new int[x, y, z];
    int value = 9;
    for (int zIndex = 0; zIndex < z; zIndex++)
    {
        for (int xIndex = 0; xIndex < x; xIndex++)
        {
            Console.Write("\n");
            for (int yIndex = 0; yIndex < y; yIndex++)
            {
                value++;
                if (value > 99)
                {
                    value = -99;
                }
                matrix3[xIndex, yIndex, zIndex] = value;
                Console.Write($"{matrix3[xIndex, yIndex, zIndex]}({xIndex}, {yIndex}, {zIndex}) ");
            }
        }
    }
}
