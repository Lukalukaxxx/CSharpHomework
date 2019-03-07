using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNumber
{
    class Program
    {
        static int N;
        static int[] Data;
        static void Solve()
        {
            int Max, Min, q, sum;
            Max = Data.Max();
            Min = Data.Min();
            sum = Data.Sum();
            q = sum/N;
            Console.WriteLine("Max: " + Max);
            Console.WriteLine("Min: " + Min);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + q);
            Console.WriteLine("Sum: " + sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Write the length and then the numbers");
            N = Convert.ToInt32(Console.ReadLine());
            Data = new int[N];
            for (int i = 0; i < N; i++)
                Data[i] = Convert.ToInt32(Console.ReadLine());
            Solve();
        }
    }
}
