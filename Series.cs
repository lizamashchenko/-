using System;
using MyUtils;

namespace Series
{
    class Series
    {
        static void Main()
        {
            Series1Utils();
        }
        static void Series1()
        {
            int[] A = new int[10];
            int sum = 0;
            Random r = new Random(20);
            for (int i = 0; i <= 10; i++)
            {
                A[i] = r.Next();                
            }
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + A[i];
            }
            Console.WriteLine(sum);
        }
        static void Series1Utils()
        {
            int A = 1, B = 50, length = 10,sum=0;
            int[] a = Aray.ArayGenerate(A, B, length);
            for (int i = 0; i < 10; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
        static void Series2()
        {
            int[] A = new int[10];
            int dob = 1;
            Random r = new Random(20);
            for (int i = 0; i <= 10; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= 10; i++)
            {
                dob = dob * A[i];
            }
            Console.WriteLine(dob);
        }
        static void Series3()
        {
            int[] A = new int[10];
            int sum = 0;
            Random r = new Random(20);
            for (int i = 0; i <= 10; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= 10; i++)
            {
                sum = sum + A[i];
            }
            int avr = sum / 10;
            Console.WriteLine(avr);
        }
        static void Series4()
        {
            int N = 23;
            int[] A = new int[N];
            int sum = 0;
            int dob = 1;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i++)
            {
                sum = sum + A[i];
                dob = dob * A[i];
            }
            Console.WriteLine(sum + " " + dob);
        }
        static void Series5()
        {
            int N = 32;
            double[] A = new double[N];
            double sum = 0;
            double zel = 0;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i++)
            {
                zel = A[i] / 1;
                sum = sum + zel;
                Console.Write(zel + " ");
            }
            Console.WriteLine(sum);
        }
        static void Series6()
        {
            int N = 24;
            double[] A = new double[N];
            double dob = 1;
            double drob = 0;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i++)
            {
                drob = A[i] % 1;
                dob = dob * drob;
                Console.Write(drob + " ");
            }
            Console.WriteLine(drob);
        }
        static void Series7()
        {
            int N = 17;
            double[] A = new double[N];
            double sum = 0;
            double rnd = 0;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i++)
            {
                rnd = Math.Round(A[i]);
                sum = sum + rnd;
                Console.Write(rnd + " ");
            }
            Console.WriteLine(sum);
        }
        static void Series8()
        {
            int N = 12;
            int[] A = new int[N];
            int K = 0;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Console.Write(A[i]+" ");
                    K = K + 1;
                }
                Console.WriteLine(K);
            }
        }
        static void Series9()
        {
            int N = 9;
            int[] A = new int[N];
            int K = 0;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            for (int i = 0; i <= N; i++)
            {
                if (A[i] % 2 == 1)
                {
                    Console.Write(i + " ");
                    K = K + 1;
                }
                Console.WriteLine(K);
            }
        }
        static void Series10()
        {
            int N = 12;
            int[] A = new int[N];
            int K = 0;
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            int j = 1;
            while (K == 0)
            {
                if (A[j] > 0)
                {
                    K = K + 1;
                    j = j + 1;
                }
                else
                {
                    j = j + 1;
                }
            }
            if (K == 1)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }
        static void Series11()
        {
            int N = 15;
            int K = 3;
            int count = 0;
            int[] A = new int[N];
            Random r = new Random(20);
            for (int i = 0; i <= N; i++)
            {
                A[i] = r.Next();
            }
            int j = 1;
            while (count == 0)
            {
                if (A[j] < K)
                {
                    count = count + 1;
                    j = j + 1;
                }
                else
                {
                    j = j + 1;
                }
            }
            if (count == 1)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }
        static void Series12()
        {
            int[] A = new int[100];
            int K = 0;
            Random r = new Random(3);
            for (int i = 0; i <= A.Length; i++)
            {
                A[i] = r.Next();
            }
            int j = 1;
            while (K == 0)
            {
                if (A[j] == 0)
                {
                    K = K + 1;
                    j = j + 1;
                }
                else
                {
                    j = j + 1;
                }
            }
            Console.WriteLine(j);
        }
        static void Series13()
        {
            int[] A = new int[100];
            int K = 1;
            int sum = 0;
            Random r = new Random(3);
            for (int i = 0; i <= A.Length; i++)
            {
                A[i] = r.Next();
            }
            int j = 1;
            while (K == 0)
            {
                if (A[j] == 0)
                {
                    K = K + 1;
                    j = j + 1;
                }
                else if (A[j] > 0 && A[j] % 2 == 0)
                {
                    sum = sum + A[j];
                }
                else
                {
                    j = j + 1;
                }
            }
            Console.WriteLine(sum);
        }
        static void Series14()
        {
            int[] A = new int[100];
            int K = 1;
            int c = 0;
            int sum = 0;
            Random r = new Random(3);
            for (int i = 0; i <= A.Length; i++)
            {
                A[i] = r.Next();
            }
            int j = 1;
            while (c == 0)
            {
                if (A[j] == 0)
                {
                    c = c + 1;
                    j = j + 1;
                }
                else if (A[j] < K)
                {
                    sum = sum + 1;
                }
                else
                {
                    j = j + 1;
                }
            }
            Console.WriteLine(sum);
        }
        static void Series15()
        {
            int[] A = new int[100];
            int K = 2;
            int c = 0;
            int imin = 0;
            Random r = new Random(3);
            for (int i = 0; i <= A.Length; i++)
            {
                A[i] = r.Next();
            }
            int j = 1;
            while (c == 0)
            {
                if (A[j] == 0)
                {
                    c = c + 1;
                    j = j + 1;
                }
                else if (A[j] < K)
                {
                    imin = j;
                    c = c + 1;
                }
                else
                {
                    j = j + 1;
                }
            }
            Console.WriteLine(imin);
        }
    }
}
