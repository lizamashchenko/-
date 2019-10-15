using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtils;   

namespace Proc
{
    class Proc
    {
        static void Main()
        {
        }
        static int Sign(int x)
        {
            if (x < 0) return (-1);
            else if (x == 0) return (0);
            else return (1);
        }
        static void Proc16()
        {
            int X = 3;
            Sign(X);
        }
        static int RootsCount(int A, int B, int C)
        {
            int D = B * B - 4 * A * C;
            if (D > 0) return (2);
            else if (D == 0) return (1);
            else return (0);
        }
        static void Proc17()
        {
            int A = 9, B = 8, C = 10;
            RootsCount(A, B, C);
        }
        static double CircleS(int R)
        {
            double S = Math.PI * R * R;
            return (S);
        }
        static void Proc18()
        {
            int R1 = 3, R2 = 8, R3 = 21;
            CircleS(R1);
            CircleS(R2);
            CircleS(R3);
        }
        static double RingS(int R1, int R2)
        {
            double S1 = R1 * Math.PI;
            double S2 = R2 * Math.PI;
            return (S1 - S2);
        }
        static void Proc19()
        {
            int R1 = 3, R2 = 1;
            RingS(R1, R2);
        }
        static double TriangleP(int a, int h)
        {
            double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
            return (b);
        }
        static void Proc20()
        {
            int a = 6, h = 2;
            TriangleP(a, h);
        }
        static int SumRange(int A, int B)
        {
            int sum = 0;
            if (A > B) return (0);
            else
            {
                for (int i = A; i <= B; i++)
                {
                    sum = sum + i;
                }
                return (sum);
            }
        }
        static void Proc21()
        {
            int A = 2, B = 2, C = 0;
            if (C == 0) Console.Write(SumRange(A, B));
            else Console.WriteLine(SumRange(A, B) + SumRange(B, C));
        }
        static int Calc(int A, int B, int Op)
        {
            int rez = 0;
            switch (Op)
            {
                case 1:
                    rez = A - B;
                    break;
                case 2:
                    rez = A * B;
                    break;
                case 3:
                    rez = A / B;
                    break;
                default:
                    rez = A + B;
                    break;
            }
            return (rez);
        }
        static void Proc22()
        {
            int A = 3, B = 9, N1 = 2, N2 = 3, N3 = 1;
            Calc(A, B, N1);
            Console.WriteLine();
            Calc(A, B, N2);
            Console.WriteLine();
            Calc(A, B, N3);
        }
        static int Quarter(int x, int y)
        {
            if (x > 0 && y > 0) return (1);
            else if (x < 0 && y > 0) return (2);
            else if (x < 0 && y < 0) return (3);
            else return (4);
        }
        static void Proc23()
        {
            int x1 = 2, y1 = 3, x2 = 3, y2 = 4, x3 = 1, y3 = 7;
            Quarter(x1, y1);
            Console.WriteLine();
            Quarter(x2, y2);
            Console.WriteLine();
            Quarter(x3, y3);
        }
        static bool Even(int K)
        {
            bool rez = true;
            if (K % 2 == 0) rez = true;
            else rez = false;
            return (rez);
        }
        static void Proc24()
        {
            MyUtils.Aray.ArayGenerate(1, 100, 10);
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Even(A[i]) == true) count++;
            }
            Console.Write(count);
        }
        static bool IsSquare(int K)
        {
            bool rez = true;
            if (K % K == 0) rez = true;
            else rez = false;
            return (rez);
        }
        static void Proc25()
        {
            MyUtils.Aray.ArayGenerate(1, 100, 10);
            int count = 0;
            for (int i = 1; i < 10; i++)
            {
                if (IsSquare(A[i]) = true) count++;
            }
            Console.WriteLine(count);
        }
        static bool IsPrime(int N)
        {
            bool rez = true;
            int count = 0;
            for (int i = 2; i <= N / 2; i++)
                if (N % 2 == 0) count++;
            if (count >= 1) rez = false;
            else rez = true;
            return (rez);
        }
        static void Proc28()
        {
            MyUtils.Aray.ArayGenerate(1, 100, 10);
            int count = 0;
            for (int i = 1; i < 10; i++)
            {
                if (IsPrime(A[i]) = true) count++;
            }
            Console.WriteLine(count);
        }
        static int DigitCount(int K)
        {
            int count = 0;
            while (K != 1)
            {
                count++;
                K = K / 10;
            }
            return (count);
        }
        static void Proc29()
        {
            int n1 = 3, n2 = 4, n3 = 6, n4 = 90;
            int sum = DigitCount(n1) + DigitCount(n2) + DigitCount(n3) + DigitCount(n4);
            Console.WriteLine(sum);
        }
        static int DigitN(int K, int N)
        {
            int rez = 0;
            for (int i = 1; i < K - N; i++)
            {
                rez = K % 10;
                K = K / 10;
            }
            return (rez);
        }
        static void Proc30()
        {
            int K1 = 2, K2 = 98, K3 = 0, K4 = 14, K5 = 21, N = 4;
            DigitN(K1, N);
            Console.WriteLine();
            DigitN(K2, N);
            Console.WriteLine();
            DigitN(K3, N);
            Console.WriteLine();
            DigitN(K4, N);
            Console.WriteLine();
            DigitN(K5, N);
        }
        static bool IsPalindrom(int K)
        {
            int count = DigitCount(K);
            int k = 0;
            while (k == 0)
            {
                for (int i = 1; i < count / 2; i++)
                {
                    if (DigitN(K, i) != DigitN(K, count - i + 1)) k++;
                }
            }
            bool rez = true;
            if (k == 0) rez = true;
            else rez = false;
            return (rez);
        }
        static void Proc31()
        {
            int[] a = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(1000);
            }
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (IsPalindrom(a[i]) == true) count++;
            }
            Console.WriteLine(count);
        }
        static double DegToRad(int R)
        {
            double rez = R * Math.PI / 180;
            return (rez);
        }
        static void Proc32()
        {
            int angle1 = 23;
            int angle2 = 12;
            int angle3 = 2;
            int angle4 = 35;
            int angle5 = 46;
            RadToDeg(angle1);
            RadToDeg(angle2);
            RadToDeg(angle3);
            RadToDeg(angle4);
            RadToDeg(angle5);
        }
        static double RadToDeg(int R)
        {
            double rez = 180 * R / Math.PI;
            return (rez);
        }
        static void Proc33()
        {
            int angle1 = 24;
            int angle2 = 2;
            int angle3 = 126;
            int angle4 = 103;
            int angle5 = 90;
            DegToRad(angle1);
            DegToRad(angle2);
            DegToRad(angle3);
            DegToRad(angle4);
            DegToRad(angle5);
        }
        static int Fact(int N)
        {
            int rez = 1;
            for (int i = 2; i <= N; i++)
            {
                rez = rez * i;
            }
            return (rez);
        }
        static void Proc34()
        {
            int N1 = 2;
            int N2 = 3;
            int N3 = 10;
            int N4 = 5;
            int N5 = 8;
            Fact(N1);
            Fact(N2);
            Fact(N3);
            Fact(N4);
            Fact(N5);
        }
        static int Fact2(int N)
        {
            int rez = 1;
            if (N % 2 == 0)
            {
                for (int i = 1; i < N; i = i + 2)
                {
                    rez = rez * i;
                }
            }
            else
            {
                for (int i = 2; i < N; i = i + 2)
                {
                    rez = rez * i;
                }
            }
            return (rez);
        }
        static void Proc35()
        {
            int N1 = 5;
            int N2 = 1;
            int N3 = 9;
            int N4 = 7;
            int N5 = 3;
            Fact2(N1);
            Fact2(N2);
            Fact2(N3);
            Fact2(N4);
            Fact2(N5);
        }
        static int Fib(int N)
        {
            int[] a = new int[N];
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i <= N; i++) 
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return (a[N]);
        }
        static void Proc36()
        {
            int N1 = 12;
            int N2 = 3;
            int N3 = 18;
            int N4 = 23;
            int N5 = 17;
            Fib(N1);
            Fib(N2);
            Fib(N3);
            Fib(N4);
            Fib(N5);
        }
        static int Power1(int A, double B)
        {
            int rez = 0;
            for (int i = 1; i < B; i++) rez = rez * A;
            return (rez);
        }
        static void Proc37()
        {
            int P = 8;
            int A = 3;
            int B = 2;
            int C = 4;
            Power1(A, P);
            Power1(B, P);
            Power1(C, P);
        }
        static double Power2(int A,double N)
        {
            if (N == 0) return (1);
            else if (N > 0) return (Power1(A, N));
            else return (1 / Power1(A, N));
        }
        static void Proc38()
        {
            int A = 2;
            int K = 8;
            int L = 87;
            int M = 34;
            Power2(A, K);
            Power2(A, L);
            Power2(A, M);
        }
        static double Power3(int A,double B)
        {
            double rez = 0;
            if (B % 1 == 0) rez = Power2(A, Math.Round(B));
            else rez = Power1(A, B);
            return (rez);
        }
        static void Proc39()
        {
            int P = 4;
            int A = -3;
            int B = 0;
            int C = 3;
            Power3(A, P);
            Power3(B, P);
            Power3(C, P);
        }
        static int
    }
}
