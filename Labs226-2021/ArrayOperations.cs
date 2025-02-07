﻿using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace Labs226_2021
{
    class ArrayOperations
    {
        // 1. Найти максимальный элемент матрицы в каждой строке
        // 2. Найти сумму элементов главной диагонали матрицы


        public static void TwoDimensionalArrayEx1()
        {
            int[,] array = new int[10, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 50);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayBubbleSort()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buf = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buf;
                    }
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                for (int k = 0; k < array.Length; k++)
                {
                    Console.Write($"{array[k]} ");
                }

            }


        }
    }
}
