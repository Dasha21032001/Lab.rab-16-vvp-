using System;

namespace Лаб.раб__16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int[] B = new int[N];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            int j=0;
            for (int i = 0; i < N-2; i++)
            {
                if (A[i] == A[i + 1])
                {
                    B[j] = A[i+2];
                    j++;
                    i+=2;
                }
                else
                {
                    B[j] = A[i];
                    j++;
                }
            }
            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < N-2; i++)
            {
                Console.WriteLine(" " + B[i]);
            }
            Console.ReadLine();
        }
    }
}

