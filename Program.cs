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

            for (int i = 0; i < arrayInt.Length; i++)
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
                    }

                    if (arrayInt[j] < minNumber)
                    {
                        minNumber = arrayInt[j];
                    }
                }
            }

            Console.WriteLine($"Max = {maxNumber} Min = {minNumber}");
        }
    }
}
