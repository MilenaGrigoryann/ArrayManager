using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager arrayManager = new ArrayManager();
            int[,] arr2D = arrayManager.Create(4, 5, 10, 80);
            arrayManager.Print(arr2D);

            Console.WriteLine();

            int min = arrayManager.GetMin(arr2D);
            int max = arrayManager.GetMax(arr2D);
            int minIndex1 = arrayManager.GetMinIndex1(arr2D);
            int minIndex2 = arrayManager.GetMinIndex2(arr2D);
            int maxIndex1 = arrayManager.GetMaxIndex1(arr2D);
            int maxIndex2 = arrayManager.GetMaxIndex2(arr2D);
            int[,] swapArr = arrayManager.Swap(arr2D, min, max, minIndex1, minIndex2, maxIndex1, maxIndex2);
            arrayManager.Print(swapArr);

            Console.WriteLine();

            ArrayManager arrayManager1 = new ArrayManager();
            int[] arr1D = arrayManager1.Create(4, 5, 50);
            arrayManager1.Print(arr1D);

            Console.WriteLine();

            int min1 = arrayManager1.GetMin(arr1D);
            int max1 = arrayManager1.GetMax(arr1D);
            int minIndex = arrayManager1.GetMinIndex(arr1D);
            int maxIndex = arrayManager1.GetMaxIndex(arr1D);
            int[] swapArr1D = arrayManager1.Swap(arr1D, min1, max1, minIndex, maxIndex);
            arrayManager.Print(swapArr1D);

            Console.ReadKey();

        }

    }

    public class ArrayManager
    {
        #region 2DArray
        public int[,] Create(int height, int width, int minGenerated, int maxGenerated)
        {
            int[,] arr = new int[height, width];
            Random rnd = new Random();
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rnd.Next(minGenerated, maxGenerated);

                }

            }
            return arr;
        }
        public void Print(int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        public int GetMax(int[,] arr)
        {

            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }

            return max;
        }
        public int GetMin(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
            }
            return min;
        }
        public int GetMaxIndex1(int[,] arr)
        {
            int maxIndex1 = 0;
            int maxIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[maxIndex1, maxIndex2])
                    {
                        maxIndex1 = i;
                        maxIndex2 = j;

                    }
                }
            }
            return maxIndex1;

        }
        public int GetMaxIndex2(int[,] arr)
        {
            int maxIndex1 = 0;
            int maxIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[maxIndex1, maxIndex2])
                    {
                        maxIndex1 = i;
                        maxIndex2 = j;

                    }
                }
            }
            return maxIndex2;

        }
        public int GetMinIndex1(int[,] arr)
        {
            int minIndex1 = 0;
            int minIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[minIndex1, minIndex2])
                    {
                        minIndex1 = i;
                        minIndex2 = j;

                    }
                }
            }
            return minIndex1;
        }
        public int GetMinIndex2(int[,] arr)
        {
            int minIndex1 = 0;
            int minIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[minIndex1, minIndex2])
                    {
                        minIndex1 = i;
                        minIndex2 = j;

                    }
                }
            }
            return minIndex2;
        }

        public int[,] Swap(int[,] arr, int min, int max, int minIndex1, int minIndex2, int maxIndex1, int maxIndex2)
        {

            arr[minIndex1, minIndex2] = max;
            arr[maxIndex1, maxIndex2] = min;

            return arr;
        }
        #endregion

        #region 1DArray
        public int[] Create(int height, int minGenerated, int maxGenerated)
        {
            int[] arr = new int[height];
            Random rnd = new Random();
            for (int i = 0; i < height; i++)
            {
                arr[i] = rnd.Next(minGenerated, maxGenerated);
            }
            return arr;
        }
        public void Print(int[] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                Console.Write($"{arr[i]}  ");

            }
            Console.WriteLine();
        }
        public int GetMax(int[] arr)
        {

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                    max = arr[i];

            }

            return max;
        }
        public int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < min)
                    min = arr[i];

            }
            return min;
        }
        public int GetMaxIndex(int[] arr)
        {
            int maxIndex = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;

                }

            }
            return maxIndex;
        }

        public int GetMinIndex(int[] arr)
        {
            int minIndex = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {

                if (arr[i] < arr[minIndex])

                    minIndex = i;
            }
            return minIndex;
        }
        public int[] Swap(int[] arr, int min, int max, int minIndex, int maxIndex)
        {

            arr[minIndex] = max;
            arr[maxIndex] = min;

            return arr;
        }
        #endregion
    }
}