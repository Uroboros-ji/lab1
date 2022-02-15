using System;

//namespace ConsoleApp1
namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число ");
            int N = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            N += 5;
            N *= 2;
            N -= 5;
            Console.WriteLine("измененное число ");
            Console.WriteLine(N);
            Console.WriteLine("Массив:");
            int[] array = new int[N];
            
            for (int j = 0; j < N; j++)
            {
                array[j] = r.Next(-100, 101);
                Console.WriteLine(array[j]);
            }
        }
    }
}