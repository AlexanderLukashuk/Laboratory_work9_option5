using System;

namespace Task9v5
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Ввести целочисленный массив, состоящий из 9 элементов.
            //* Поменять местами максимальный и минимальный элементы массива.

            int[] arrayInt = new int[9];
            Random random = new Random();
            int maxNumber = 0;
            int minNumber = 0;
            int minIndex = 0;
            int maxIndex = 0;

            /*for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = random.Next(100);
                Console.Write($"{arrayInt[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (minNumber == 0)
                {
                    minNumber = arrayInt[i];
                }
                for (int j = i; j < arrayInt.Length; j++)
                {
                    if (maxNumber < arrayInt[j])
                    {
                        maxNumber = arrayInt[j];
                        maxIndex = j;
                    }

                    if (arrayInt[j] < minNumber)
                    {
                        minNumber = arrayInt[j];
                        minIndex = j;
                    }
                }
            }

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (i == maxIndex)
                {
                    arrayInt[i] = minNumber;
                }

                if (i == minIndex)
                {
                    arrayInt[i] = maxNumber;
                }

                Console.Write($"{arrayInt[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Max = {maxNumber} Min = {minNumber}");*/

            //* Ввести два массива X и Y, состоящих из 10-ти элементов целого типа. 
            //* Сформировать массив S, состоящий из одинаковых элементов исходных 
            //* массивов.

            int[] X = new int[10];
            int[] Y = new int[10];
            int size = 0;

            for (int i = 0; i < 10; i++)
            {
                X[i] = random.Next(160 / 2);
                Y[i] = random.Next(160 / 2);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{X[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{Y[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    {
                        size++;
                    }
                }
            }
            Console.WriteLine($"size = {size}");

            int[] S = new int[size];
            int SArrayStep = 0;

            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < Y.Length; j++)
                {
                    if (X[i] == Y[j])
                    {
                        S[SArrayStep] = X[i];
                        SArrayStep++;
                    }
                }
            }

            for (int i = 0; i < S.Length; i++)
            {
                Console.Write($"{S[i]} ");
            }
            Console.WriteLine();


            //* Дано дробное число в двоичной системе счисления, т.е. последователь-
            //* ность цифр 0 и 1, разделенных точкой. Составить программу перевода 
            //* этого числа в восьмеричную систему счисления.
        }
    }
}
