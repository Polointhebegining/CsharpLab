using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Laba1
{
    public class Program
    {
        public static void Main()
        {

            //Вариант 4 
            System.Console.WriteLine("часть 1");
            //часть 1 
            //В одномерном массиве, состоящем из N вещественных элементов, вычислить:

            double[] _arr = new double[] { 1, -2, 3, 1, -4, -5, 11, -38, -1 };

            //1). сумму элементов массива с нечетными номерами 
            System.Console.Write("1). ");

            SumNechEl(_arr);
                      

            //2). сумму элементов массива, расположенных между первым и последним отрицательными элементами. 
            System.Console.Write("2). ");

            SumBetwinNeg(_arr);
            

            //3). Сжать массив, удалив из него все элементы, модуль которых не превышает единицу. 
            // Освободившиеся в конце массива элементы заполнить нулями.
            System.Console.Write("3). ");

            DelOne(_arr);
            System.Console.WriteLine();

            //Вариант 4
            //часть 2
            System.Console.WriteLine("часть 2");
            //Дана целочисленная квадратная матрица.

            int[,] _SquarArr = new int[4, 4] { { 1, -2, 3, 0 }, { -4, -5, 11, -38 }, { 5, -4, 88, -3 }, { 0, -1, 18, -30 } };
            int[] _helper = new int[6];

            //Определить:
            //максимум среди сумм элементов диагоналей, параллельных главной диагонали матрицы.

            MaxSummX(_SquarArr, _helper);


        }
        //метод для 1 таска
        public static double SumNechEl(double[] arr)
        {
            double SumNech = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                SumNech = SumNech + arr[i];
            }
            return SumNech;
        }

        //метод для 2 таска
        public static double SumBetwinNeg(double[] arr)
        {
            int MinInd = -1;
            int MaxInd = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    if (MinInd == -1) MinInd = i;
                    if (i > MaxInd) MaxInd = i;
                }
            }

            double summa = 0;
            for (int i = MinInd + 1; i < MaxInd; i++)
            {
                summa += arr[i];
            }

            return summa;
        }

        //метод для 3 таска
        public static double[] DelOne(double[] arr)
        {
            double[] newArr = new double[arr.Length]; // заполнаем 0-ми пустой массив
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = 0;
            }

            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 1 || arr[i] != -1)
                {
                    newArr[num] = arr[i];
                    num++;
                }
            }
            return newArr;
        }


        //метод для 2 части 1 таска
        public static int MaxSummX(int[,] SquarArr, int[] helper)
        {
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

            return maxSumma;
        }
    }
}
