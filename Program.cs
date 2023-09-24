// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

//Вариант 4 
Console.WriteLine("часть 1");
//часть 1 
//В одномерном массиве, состоящем из N вещественных элементов, вычислить:

decimal[] arr = new decimal[]{1, -2, 3, 1, -4, -5, 11, -38, -1};

//1). сумму элементов массива с нечетными номерами +++++++++++++++++++++++++++++++++++++++++++++++++
Console.Write("1). ");

decimal SumNech = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    SumNech = SumNech + arr[i];
}
Console.WriteLine(SumNech);

//2). сумму элементов массива, расположенных между первым и последним отрицательными элементами. ++++++++++++++
Console.Write("2). ");

int MinInd = -1;
int MaxInd = -1;
for (int i = 0; i < arr.Length; i ++)
{
    if (arr[i] < 0)
    {
        if (MinInd == -1) MinInd = i;
        if (i > MaxInd) MaxInd = i;
    }
}

decimal summa = 0;
for (int i = MinInd + 1; i < MaxInd; i ++)
{
    summa += arr[i];
}

Console.WriteLine(summa);

//3). Сжать массив, удалив из него все элементы, модуль которых не превышает единицу. ++++++++++++++++++++++++++
// Освободившиеся в конце массива элементы заполнить нулями.
Console.Write("3). ");

decimal[] newArr = new decimal[arr.Length]; // заполнаем 0-ми пустой массив
for(int i = 0; i < newArr.Length; i++)
{
    newArr[i] = 0;
}

int num = 0;
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 1 || arr[i] == -1)
    {
        newArr[num] = (arr[i]);
        num++;
    }
}

for(int i = 0; i < newArr.Length; i++)
{
    Console.Write("[" + newArr[i] + "] ");
}

Console.WriteLine();

//Вариант 4
//часть 2
Console.WriteLine("часть 2");
//Дана целочисленная квадратная матрица.

int[,] SquarArr = new int[4, 4]{{1, -2, 3, 0}, {-4, -5, 11, -38}, {5, -4, 88, -3}, {0, -1, 18, -30}};
int[] helper = new int[6] ;

//Определить:
//максимум среди сумм элементов диагоналей, параллельных главной диагонали матрицы.

int Index = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (i > j)
        {
            Index = i - j - 1;
            helper[Index] += SquarArr[i, j];
        }
        if (i < j)
        {
            Index = j - i + 2;
            helper[Index] += SquarArr[i, j];
        }
    }
}

int maxSumma = helper.Max();

Console.WriteLine(maxSumma);