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
            Vis = new int[Num + 1];
            Pri = new int[Num + 1];
            Console.WriteLine("Prime 2~100");
            for (int i = 2; i <= Num; i++)
            {
                if (Vis[i] == 0) {
                    Pri[++lenP] = i;
                    Console.Write(i + " ");
                }
                
                for (int j = 1; j <= lenP; j++)
                {
                    int t = Pri[j] * i;
                    if (t > Num) break;
                    Vis[t] = 1;
                    if (i % Pri[j] == 0) break;
                }
            }
        }

        static void Main(string[] args)
        {
            Solve(100);
        }
    }
}
