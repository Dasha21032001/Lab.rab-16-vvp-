using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[10000];
            int min = 10000, max = -1000, i = 0;
            Console.WriteLine("Введите элементы массива: ");
            for ( i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            for (i = 0; i < N; i++)
            {
                
                if (A[i] < min)
                {
                    min = A[i];
                }
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            A[N + 1] = 0;
            A[N + 2] = 0;
             i = N + 1;
            while (A[i] != min)
            {
                A[i] = A[i - 1];
                i--;
            }
             A[i] = 0;
            i = N + 2;
            while (A[i] != max)
            {
                A[i] = A[i - 1];
                i--;
            }
             A[i + 1] = 0;
            Console.WriteLine("Новый массив: ");
            for (i = 0; i <= N + 1; i++)
            {
                Console.WriteLine(" " + A[i]);
            }
            Console.ReadLine();
        }
    }
}
