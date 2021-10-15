using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    static class MatrixExt
    {
        public static int RowsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        public static int ColumnsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
    }
    class Program
    {
        static int[,] GetMatrixFromConsole(string name)
        {
            Console.Write("Количество строк матрицы {0}:    ", name);
            var n = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы {0}: ", name);
            var m = int.Parse(Console.ReadLine());

            var matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    Console.Write("{0}[{1},{2}] = ", name, i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.RowsCount(); i++)
            {
                for (var j = 0; j < matrix.ColumnsCount(); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }

                Console.WriteLine();
            }
        }
        static double[] GetArrayOFAverageTemperature(double[,] temperature)
        {
            double[] temperatureAverage = new double[temperature.GetLength(0)];
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    temperatureAverage[i] += temperature[i, j];
                }
                temperatureAverage[i] /= 12;
            }
            return temperatureAverage;
        }
        static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrixC;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 6.1");
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine().ToLower();
            char[] vowelsCh = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            char[] consonantsCh = { 'ч', 'с', 'м', 'т', 'б', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х' };
            int vowels = 0, consonants = 0, sumall = 0;
            bool isVowel, isConsonant;
            for(int i = 0; i < str.Length; i++)
            {
                sumall++;
                isVowel = false;
                isConsonant = false;
                for (int j = 0; j < vowelsCh.Length; j++)
                {
                    if (str[i] == vowelsCh[j])
                    {
                        vowels++;
                        isVowel = true;
                    }
                }
                if (isVowel == false)
                {
                    for (int k = 0; k < consonantsCh.Length; k++)
                        if (str[i] == consonantsCh[k])
                        {
                            consonants++;
                            isConsonant = true;
                        }
                }

            }
            Console.WriteLine("Количество глассных: " + vowels);
            Console.WriteLine("Количество соглассных: " + consonants);


            Console.WriteLine("Упражнение 6.2");
            var a = GetMatrixFromConsole("A");
            var b = GetMatrixFromConsole("B");
            Console.WriteLine("Матрица A:");
            PrintMatrix(a);
            Console.WriteLine("Матрица B:");
            PrintMatrix(b);
            var result = MatrixMultiplication(a, b);
            Console.WriteLine("Произведение матриц:");
            PrintMatrix(result);


            Console.WriteLine("Упражнение 6.3");
            double[,] temperature = new double[12, 30];
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    Random random = new Random();
                    temperature[i, j] = random.Next(600) / 10.0 - 30;
                }
            }
            double[] tAverage = GetArrayOFAverageTemperature(temperature);
            Array.Sort(tAverage);
            Console.ReadKey();
        }
    }
}
