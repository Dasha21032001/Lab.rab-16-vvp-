using System;

namespace з4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[1000];
            int[] B = new int[1000];
            int i, k=0, m=N, x=0;
            Console.WriteLine("Введите элементы массива: ");
            for (i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
                B[i] = A[i];
            }
            for (i = 0; i < N; i++)
            {
                if (A[i] < 0)
                {
                    x++;
                    m++;
                    for (k = m; k >= i + x; k--)
                    {
                        B[k] = B[k - 1];
                    }
                    B[i + x] = 0;
                }
            }
            Console.WriteLine("Новый массив: ");
            for ( i = 0; i < m; i++)
            {
                Console.WriteLine(" " + B[i]);
            }
            Console.ReadLine();
        }
    }
}
