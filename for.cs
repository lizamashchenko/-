using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void For1()
        {
            int K = 7;
            int N = 3;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(K + " ");
            }
        }
        static void For2()
        {
            int A = 3;
            int B = 6;
            int n = 0;
            for(int i = A; i <= B; i++)
            {
                n = n + 1;
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(n);
        }
        static void For3()
        {
            int A = 3;
            int B = 9;
            int N = 0;
            for (int i = B; i >= A; i--)
            {
                Console.WriteLine(i+" ");
                N = N + 1;
            }
            Console.WriteLine(N);
        }
        static void For4()
        {
            int p = 4;
            int tp = 0;
            for(int i = 1; i <= 10; i++)
            {
                tp = i * p;
                Console.WriteLine(tp + " ");
            }
        }
        static void For5()
        {
            int p = 4;
            double tp = 0;
            for (double i = 0.1; i <= 1; i=i+0.1)
            {
                tp = i * p;
                Console.WriteLine(tp + " ");
            }
        }
        static void For6()
        {
            int p = 4;
            double tp = 0;
            for (double i = 1.2; i <= 2; i=i+0.2)
            {
                tp = i * p;
                Console.WriteLine(tp + " ");
            }
        }
        static void For7()
        {
            int A = 2;
            int B = 4;
            int sum = 0;
            for (int i=A;i<=B;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        static void For8()
        {
            int A = 1;
            int B = 7;
            int dob=1;
            for(int i = A; i <= B; i++)
            {
                dob = dob * i;
            }
            Console.WriteLine(dob);
        }
        static void For9()
        {
            int A = 2;
            int B = 4;
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum = sum + i*i;
            }
            Console.WriteLine(sum);
        }
        static void For10()
        {
            int N = 5;
            int sum = 0;
            for(int i = 1; i <= N; i++)
            {
                sum = sum + 1 / i;
            }
            Console.WriteLine(sum);
        }
        static void For11()
        {
            int N = 5;
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum = sum + (i + N) * (i + N);
            }
            Console.WriteLine(sum);
        }
        static void For12()
        {
            int N = 9;
            double dob = 1;
            int k = 1;
            for (double i = 1.1; k < N; i=i+0.1)
            {
                k = k + 1;
                dob= dob * i;
            }
            Console.WriteLine(dob);
        }
        static void For13()
        {
            int N = 11;
            double sum1 = 0;
            double sum2 = 0;
            double sum = 0;
            int k1 = 1;
            int k2 = 1;
            for (double i1 = 1.1; k1 < N / 2; i1 = i1 + 0.2)
            {
                sum1 = sum1 + i1;
            }
            for (double i2 = 1.2; k2 < N / 2; i2 = i2 + 0.2)
            {
                sum2 = sum2 + i2;
            }
            sum = sum1 + sum2;
            Console.WriteLine(sum);
        }
        static void For14()
        {
            int N = 4;
            int n2 = 0;
            for (int i = 1; i <= 2 * N - 1; i = i + 2)
            {
                n2 = n2 + 1;
                Console.WriteLine(n2);
            }
        }
        static void For15()
        {
            int A = 4;
            int N = 3;
            int An = 1;
            for(int i = 1; i <= N; i++)
            {
                An = An * A;
            }
            Console.WriteLine(An);
        }
    }
}
