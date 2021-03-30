using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OOP_Lab1
{
    class Program
    {

        static int[,] iMatrix;

        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            vCreateMatrix(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Заполните {iMatrix.GetLength(0)}-мерную матрицу");
            vFillMatrix();
            vOperate();
            Console.ReadKey();
        }

        static void vCreateMatrix(int iSize)
        {
            iMatrix = new int[iSize, iSize];
        }

        static void vFillMatrix()
        {
            for (int i = 0; i < iMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < iMatrix.GetLength(0); j++)
                {
                    iMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void vOperate()
        {
            for (int i = iMatrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = iMatrix.GetLength(0) - 1; j >= 0; j--)
                {
                    Console.Write($"{iMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
