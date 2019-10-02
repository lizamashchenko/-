using System;
using System.IO;

namespace integer
{
    class integer
    {
        static void Main()
        {

        }
        static void Integer1()
        {
            int L = 6789;
            int L1 = L / 100;
            Console.WriteLine(L1);
        }
        static void Integer2()
        {
            int M = 34567;
            int M1 = M / 1000;
            Console.WriteLine(M1);
        }
        static void Integer3()
        {
            int x = 3079;
            int x1 = x / 1024;
            Console.WriteLine(x1);
        }
        static void Integer4()
        {
            int A = 39;
            int B = 8;
            int x = A / B;
            Console.WriteLine(x);
        }
        static void Integer5()
        {
            int A = 4;
            int B = 3;
            int x = A % B;
            Console.WriteLine(x);
        }
        static void Integer6()
        {
            int x = 76;
            int n1 = x / 10;
            int n2 = x % 10;
            Console.WriteLine(n1 + " " + n2);
        }
        static void Integer7()
        {
            int x = 86;
            int n1 = x / 10;
            int n2 = x % 10;
            int sum = n1 + n2;
            int dob = n1 * n2;
            Console.WriteLine(sum + " " + dob);
        }
        static void Integer8()
        {
            int x = 86;
            int n1 = x % 10;
            int n2 = x / 10;
            int y = n2 * 10 + n1;
            Console.WriteLine(y);
        }
        static void Integer9()
        {
            int x = 340;
            int n1 = x / 100;
            Console.WriteLine(n1);
        }
        static void Integer10()
        {
            int x = 789;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            Console.WriteLine(n1 + " " + n2);
        }
        static void Integer11()
        {
            int x = 876;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            int n3 = x / 100;
            int sum = n1 + n2 + n3;
            int dob = n1 * n2 * n3;
            Console.WriteLine(sum + " " + dob);
        }
        static void Integer12()
        {
            int x = 876;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            int n3 = x / 100;
            int y = n3 * 100 + n2 * 10 + n1;
            Console.WriteLine(y);
        }
        static void Integer13()
        {
            int x = 876;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            int n3 = x / 100;
            int y = n2 * 100 + n1 * 10 + n3;
            Console.WriteLine(y);
        }
        static void Integer14()
        {
            int x = 876;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            int n3 = x / 100;
            int y = n1 * 100 + n2 * 10 + n3;
            Console.WriteLine(y);
        }
        static void Integer15()
        {
            int x = 876;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            int n3 = x / 100;
            int y = n2 * 100 + n3 * 10 + n1;
            Console.WriteLine(y);
        }
        static void Integer16()
        {
            int x = 876;
            int n1 = x % 10;
            int n2 = (x / 10) % 10;
            int n3 = x / 100;
            int y = n3 * 100 + n1 * 10 + n2;
            Console.WriteLine(y);
        }
        static void Integer17()
        {
            int x = 1234;
            int x1 = x / 100;
            int x2 = x1 % 10;
            Console.WriteLine(x2);
        }
        static void Integer18()
        {
            int x = 1094;
            int x1 = x / 1000;
            int x2 = x1 % 10;
            Console.WriteLine(x2);
        }
        static void Integer19()
        {
            int x = 1984;
            int x1 = x / 60;
            Console.WriteLine(x1);
        }
        static void Integer20()
        {
            int x = 5684;
            int x1 = x / 60;
            int x2 = x1 / 60;
            Console.WriteLine(x2);
        }
        static void Integer21()
        {
            int x = 9784;
            int x1 = x % 60;
            Console.WriteLine(x1);
        }
        static void Integer22()
        {
            int x = 3454;
            int x1 = x % 3600;
            Console.WriteLine(x1);

        }
        static void Integer23()
        {
            int x = 1234;
            int x1 = x % 3600;
            int x2 = x1 / 60;
            Console.WriteLine(x2);
        }
        static void Integer25()
        {
            int K = 234;
            int r = (K - 3) % 7;
            Console.WriteLine(r);
        }
        static void Integer24()
        {
            int K = 64;
            int r = K % 7;
            Console.WriteLine(r);
        }
        static void Integer26()
        {
            int K = 127;
            int r = (K - 1) % 7;
            Console.WriteLine(r);
        }
        static void Integer27()
        {
            int K = 344;
            int r = (K - 5) % 7;
            Console.WriteLine(r);
        }
        static void Integer28()
        {
            int K = 234;
            int N = 5;
            int r = (K - N - 1) % 7;
            Console.WriteLine(r);
        }
        static void Integer29()
        {
            int A = 10;
            int B = 49;
            int C = 2;
            int S1 = A * B;
            int S2 = C * C;
            int x = S1 / S2;
            int d = S1 - (S2 * x);
            Console.WriteLine(x + " " + d);
        }
        static void Integer30()
        {
            int x = 1987;
            int r = (x / 100) + 1;
            Console.WriteLine(r);
        }
    }
}
