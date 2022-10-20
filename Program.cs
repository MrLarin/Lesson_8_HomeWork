/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

int[,] Array = CreateArray(3, 4);
int temp = 0;
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int k = 0; k < Array.GetLength(1) - 1; k++)
    {
        for (int j = 0; j < Array.GetLength(1) - 1; j++)
        {
            if (Array[i, j] < Array[i, j + 1])
            {
                temp = Array[i, j];
                Array[i, j] = Array[i, j + 1];
                Array[i, j + 1] = temp;
                temp = 0;
            }
        }
    }
}
Console.WriteLine();

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        {
            Console.Write($"{Array[i, j]} ");
        }
    }
    Console.WriteLine();
}
*/

/*Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Array = CreateArray(4, 4);
Console.WriteLine();
int sum = 0;
for (int j = 0; j < Array.GetLength(1); j++)
{
    sum += Array[0, j];
}
int M = 0;
for (int i = 1; i < Array.GetLength(0); i++)
{
    int tsum = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        tsum += Array[i, j];
    }
    if (tsum < sum)
    {
        sum = tsum;
        M = i;
    }
}
Console.Write($"Минимальная сумма {M} = {sum} \n");
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

int[,] Array1 = CreateArray(2, 2);
Console.WriteLine();
int[,] Array2 = CreateArray(2, 2);
Console.WriteLine();
int[,] Array3 = new int[Array1.GetLength(0), Array2.GetLength(1)];
if (Array1.GetLength(0) != Array2.GetLength(1))
{
    Console.Write($"Произведение матриц невозможно из-за несоответсвия размеров \n");
}
for (int i = 0; i < Array1.GetLength(0); i++)
{
    for (int j = 0; j < Array1.GetLength(1); j++)
    {
        for (int k = 0; k < Array1.GetLength(1); k++)
        {
            Array3[i, j] += (Array1[i, k] * Array2[k, j]);
        }
    }
}
for (int i = 0; i < Array3.GetLength(0); i++)
{
    for (int j = 0; j < Array3.GetLength(1); j++)
    {
        Console.Write($"{Array3[i, j]} ");
    }
    Console.WriteLine();
}
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)

int[,,] Array3 = new int[2, 2, 2];

for (int i = 0; i < Array3.GetLength(0); i++)
{
    for (int j = 0; j < Array3.GetLength(1); j++)
    {
        for (int k = 0; k < Array3.GetLength(2); k++)
        {
            Array3[i, j, k] = new Random().Next(10, 90);
            Console.Write($"{Array3[i, j, k]}({i}, {j}, {k}) ");
        }
        Console.WriteLine();
    }
}
*/

/*Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = new int[4, 4];
for (int i = 0, j = 0, t = 0; t < array.Length; t++)
{
    array[i, j] = t + 1;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(string.Format("{0:D2}", array[i, j]));
    }
    Console.WriteLine();
}


//Создание двумерного массива и вывод

int[,] CreateArray(int _m, int _n)
{
    int[,] _array = new int[_m, _n];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(1, 10);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}








