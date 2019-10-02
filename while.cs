using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void While1()
        {
            int A = 10;
            int B = 4;
            while (B <= A)
            {
                A = A - B;
            }
            Console.WriteLine(A);
        }
        static void While2()
        {
            int A = 20;
            int B = 9;
            int i = 0;
            while (A >= B)
            {
                A = A - B;
                i = i + 1;
            }
            Console.WriteLine(i);
        }
        static void While3()
        {
            int N = 32;
            int K = 10;
            int ost = 0;
            int cel = 0;
            while (N>=K)
            {
                N = N - K;
                cel = cel + 1;
                ost = N % K;
            }
            Console.WriteLine(cel + " " + ost);
        }
        static void While4()
        {
            int N = 4;
            while (N > 0)
            {
                
            }
        }
    }
}
