using System;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            int count=0, a=0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i] == A[j])
                    {
                        count++;
                         a = j;
                    }
                }
                if (count == 2)
                {
                    for ( int j = a; j < N - 1; j++)
                    {
                        A[j] = A[j + 1];
                    }
                    N--;
                    for (int j = i; j < N - 1; j++)
                    {
                        A[j] = A[j + 1];
                    }
                    N--;
                    i--;
                }
                count = 0;
            }
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" " + A[i]);
            }
            Console.WriteLine(" Размер полученного массива: " + N);
            Console.ReadLine();
        }
    }
}
