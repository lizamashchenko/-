using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtils;

namespace Array
{
    class Array
    {
        static void Main()
        {

        }
        static void Array1()
        {
            int N = 5;
            int[] A = new int[N];
            for (int i = 0; i <= N; i++)
            {
                A[i] = i + 1;
            }
            for (int i = 0; i <= N; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array2()
        {
            int N = 8;
            int[] A = new int[N];
            A[0] = 2;
            for (int i = 1; i <= N; i++)
            {
                A[i] = A[i - 1] * 2;
            }
            for (int i = 0; i <= N; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array3()
        {
            int N = 9;
            int A = 3;
            int D = 3;
            int[] a = new int[N];
            a[0] = A;
            for (int i = 1; i <= N; i++)
            {
                a[i] = a[i - 1] + D;
            }
            for (int i = 0; i <= N; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Array4()
        {
            int N = 12;
            int A = 6;
            int D = 2;
            int[] a = new int[N];
            a[0] = A;
            for (int i = 1; i <= N; i++)
            {
                a[i] = a[i - 1] * D;
            }
            for (int i = 0; i <= N; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Array5()
        {
            int N = 9;
            int[] a = new int[N];
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
            for (int i = 0; i <= N; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Array6()
        {
            int N = 32;
            int A = 2;
            int B = 4;
            int sum = A + B;
            int[] a = new int[N];
            a[0] = A;
            a[1] = B;
            for (int i = 2; i <= N; i++)
            {
                a[i] = sum;
                sum = sum + a[i];
            }
            for (int i = 0; i <= N; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Array7()
        {
            int N = 45;
            Random r = new Random(50);
            int[] a = new int[N];
            for (int i = 0; i <= N; i++)
            {
                a[i] = r.Next();
            }
            int[] b = new int[a.Length];
            for (int i = a.Length; i <= 0; i--)
            {
                b[a.Length - i] = a[i];
            }
            for (int i = 0; i <= b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
        }
        static void Array8()
        {
            int N = 23;
            int K = 0;
            Random r = new Random(50);
            int[] a = new int[N];
            for (int i = 0; i <= N; i++)
            {
                a[i] = r.Next();
            }
            for (int i = 1; i <= a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    K = K + 1;
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine(K);
        }
        static void Array9()
        {
            int N = 12;
            int K = 0;
            Random r = new Random(50);
            int[] a = new int[N];
            for (int i = 0; i <= N; i++)
            {
                a[i] = r.Next();
            }
            for (int i = a.Length; i <= 0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    K = K + 1;
                    Console.Write(a[i] + " ");
                }
            }
            Console.WriteLine(K);
        }
        static void Array10()
        {
            int N = 17;
            Random r = new Random(50);
            int[] a = new int[N];
            for (int i = 0; i <= N; i++)
            {
                a[i] = r.Next();
            }
            for (int i = 1; i <= a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
            }
            for (int i = a.Length; i <= 0; i--)
            {
                if (a[i] % 2 == 1)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
        static void Array11()
        {
            int N = 4;
            int K = 3;
            int[] A = new int[N];
            Random r = new Random(50);
            for (int i = 1; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = K; i <= N; i = i + K)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array12()
        {
            int N = 16;
            int[] A = new int[N];
            Random r = new Random(50);
            for (int i = 1; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 2; i <= N; i = i + 2)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array13()
        {
            int N = 7;
            int[] A = new int[N];
            Random r = new Random(50);
            for (int i = 1; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = N; i <= 0; i = i - 2)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array14()
        {
            int N = 15;
            int[] A = new int[N];
            Random r = new Random(50);
            for (int i = 1; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i = i + 2)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            for (int i = 1; i <= N; i = i + 2)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array15()
        {
            int N = 19;
            int[] A = new int[N];
            Random r = new Random(50);
            for (int i = 1; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 1; i <= N; i = i + 2)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            for (int i = N; i <= 0; i = i - 2)
            {
                Console.Write(A[i] + " ");
            }
        }
        static void Array16()
        {
            int N = 3;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            for (int i = 1; i < N; i = i + 2) Console.Write(A[i] + " " + A[N - 1]);
        }
        static void Array17()
        {
            int N = 23;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            for (int i = 1; i < N; i = i + 2) Console.Write(A[i] + " " + A[i + 1] + " " + A[N - 1] + " " + A[N - 2]);
        }
        static void Array18()
        {
            Aray.ArayGenerate(1, 100, 10);
            int k = 0;
            while(k==0)
            {
                for(int i=0;i<10;i++)
                {
                    if (A[i]<A[10])
                    {
                        Console.Write(A[i]);
                        k++;
                    }
                }
            }
            if (k == 0) Console.WriteLine(0);
        }
        static void Array19()
        {
            MyUtils.Aray.ArayGenerate(1, 100, 10);
            int rez = A[0];
            for (int i = 1; i < 10; i++)
            {
                if (A[i] < A[10] && A[i] > A[1]) rez = A[i];
            }
            Console.Write(rez);
        }
        static void Array20()
        {
            int N = 12;
            int L = 2;
            int K = 9;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            int rez = 0;
            for (int i = L; i <= K; i++)
            {
                rez = rez + A[i];
            }
            Console.Write(rez);
        }
        static void Array21()
        {
            int N = 5;
            int L = 1;
            int K = 3;
            int count = 0;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            int rez = 0;
            for (int i = L; i <= K; i++)
            {
                count++;
                rez = rez + A[i];
            }
            Console.Write(rez/count);
        }
        static void Array22()
        {
            int N = 19;
            int L = 9;
            int K = 12;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            int rez = 0;
            for (int i = 0; i < L; i++)
            {
                rez = rez + A[i];
            }
            for (int i = K; i < N; i++)
            {
                rez = rez + A[i];
            }
            Console.Write(rez);
        }
        static void Array23()
        {
            int N = 19;
            int L = 9;
            int K = 12;
            int count = 0;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            int rez = 0;
            for (int i = 0; i < L; i++)
            {
                rez = rez + A[i];
                count++;
            }
            for (int i = K; i < N; i++)
            {
                rez = rez + A[i];
                count++;
            }
            Console.Write(rez/count);
        }
        static void Array24()
        {
            int N = 14;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            int d = A[1] - A[0];
            int k = 0;
            while(k==0)
            {
                for (int i=1;i<N;i++)
                {
                    if(A[i+1]-A[i] != d)
                    {
                        k++;
                    }
                }
            }
            if (k == 0) Console.WriteLine(d);
            else Console.WriteLine(0);
        }
        static void Array25()
        {
            int N = 14;
            MyUtils.Aray.ArayGenerate(1, 100, N);
            int d = A[1] / A[0];
            int k = 0;
            while (k == 0)
            {
                for (int i = 1; i < N; i++)
                {
                    if (A[i + 1] / A[i] != d)
                    {
                        k++;
                    }
                }
            }
            if (k == 0) Console.WriteLine(d);
            else Console.WriteLine(0);
        }
    }
}
