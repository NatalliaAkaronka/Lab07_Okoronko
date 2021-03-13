using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Okoronko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Опрделение расположения элемента относительно maksimum, minimum, equal";
            Console.Write("Введите N - количество строк матрицы: ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Введите M - количество столбцов матрицы: ");
            int M = Int32.Parse(Console.ReadLine());
            int[,] A = new int [N, M];
            Console.WriteLine("Исходная матрица: ");
            Random rnd = new Random();
            for (int x = 0; x < A.GetLength(0); x++)
            {
                for (int y = 0; y < A.GetLength(1); y++)
                {
                    A[x, y] = (int)rnd.Next(100) + 1;
                    Console.Write(A[x, y] + "\t");
                }
                Console.WriteLine();
            }
            int max = 0;
            int a = 0, b = 0;
            for (int x = 0; x < A.GetLength(0); x++)
            {
                for (int y = 0; y < A.GetLength(1); y++)
                {
                    if (A[x, y] > max)
                    {
                        max = A[x, y];
                        a = x;
                        b = y;
                    }
                }
            }
            int min = 100;
            int c = 0, d = 0;
            for (int x = 0; x < A.GetLength(0); x++)
            {
                for (int y = 0; y < A.GetLength(1); y++)
                {
                    if (A[x, y] < min)
                    {
                        min = A[x, y];
                        c = x;
                        d = y;
                    }
                }
            }

            // Console.WriteLine("Максимальное число массива: {0}, и его индексы {1} и {2}", max, a+1, b+1);
            // Console.WriteLine("Минимельно число число массива: {0}, и его индексы {1} и {2}", min, c+1, d+1);
            Console.WriteLine("Ввод элемента Аij");
            Console.Write("Введите i, значение не должно быть больше N: ");
            int i = Int32.Parse(Console.ReadLine());
            Console.Write("Введите j, значение не должно быть больше M: ");
            int j = Int32.Parse(Console.ReadLine());
            int positionMax = M * a + b+1;
            // Console.WriteLine(positionMax);
            int positionMin = M * c + d+1;
            // Console.WriteLine(positionMin);
            int positionX = M * (i-1) + (j-1)+1;
            // Console.WriteLine(positionX);
            int distanseMax = Math.Abs(positionMax - positionX);
            // Console.WriteLine(distanseMax);
            int distanseMin = Math.Abs(positionMin - positionX);
            // Console.WriteLine(distanseMin);
            if (distanseMax < distanseMin)
            {
                Console.WriteLine("Ваш элемент находится ближе к maximum");
            }
            else if (distanseMax == distanseMin)
            {
                Console.WriteLine("Equal, Ваш элемент равноудален от обоих экстремумов");
            }
            else
            {
                Console.WriteLine("Ваш элемент находится ближе к minimum");
            }
            Console.ReadLine();
       }
    }
}
