using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        static void Solve(int Num)
        {
            int[] Vis, Pri;
            int lenP = 0;
            Vis = new int[Num+1];
            Pri = new int[Num+1];

            for (int i = 2; i <= Num; i++)
            {
                if (Vis[i] == 0)
                    Pri[++lenP] = i;
                for (int j = 1; j <= lenP; j++)
                {
                    int t = Pri[j] * i;
                    if (t > Num) break;
                    Vis[t] = 1;
                    if (i % Pri[j] == 0) break;  
                }
            }
            for (int i = 1; i <= lenP; i++)
            {
                if (Num % Pri[i] == 0)
                {
                    Console.WriteLine(Pri[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please Input a number(<100000): ");
            int N = Convert.ToInt32(Console.ReadLine());
            Solve(N);
        }
    }
}
