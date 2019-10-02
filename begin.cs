using System;
using System.IO;

namespace ConsoleApp1
{
    class begin
    {
        static void Main()
        {
            Begin1();
        }
        static void Begin1()
        {
            int a = 5;
            int P = a * 4;
            Console.WriteLine(P);
        }
        static void Begin2()
        {
            int a = 2;
            int S = a * a;
            Console.WriteLine(S);
        }
        static void Begin3()
        {
            int a = 3;
            int b = 4;
            int S = a * b;
            int P = 2 * (a + b);
            Console.WriteLine(S + " " + P);
        }
        static void Begin4()
        {
            int d = 2;
            double L = Math.PI * d;
            Console.WriteLine(L);
        }
        static void Begin5()
        {
            int a = 5;
            int V = a * a * a;
            int S = a * a * 6;
            Console.WriteLine(S + " " + V);
        }
        static void Begin6()
        {
            int a = 3;
            int b = 4;
            int c = 2;
            int V = a * b * c;
            int S = 2*(a * b + a * c + b * c);
            Console.WriteLine(S + " " + V);
        }
        static void Begin7()
        {
            int R = 2;
            double L = 2 * Math.PI * R;
            double S = Math.PI * R * R;
            Console.WriteLine(S + " " + L);
        }
        static void Begin8()
        {
            int a = 6;
            int b = 4;
            int Avg = a * b / 2;
            Console.WriteLine(Avg);
        }
        static void Begin9()
        {
            int a = 3;
            int b = 4;
            double x = Math.Sqrt(a * b);
            Console.WriteLine(x);
        }
        static void Begin10()
        {
            int a = 12;
            int b = 23;
            int x = a * a + b * b;
            int y = a * a - b * b;
            int z = a * a * b * b;
            int k = a * a / b * b;
            Console.WriteLine(x + " " + y + " " + z + " " + k);
        }
        static void Begin11()
        {
            int a = 2;
            int b = 4;
            double x = Math.Abs(a) + Math.Abs(b);
            double y = Math.Abs(a) - Math.Abs(b);
            double z = Math.Abs(a) * Math.Abs(b);
            double k = Math.Abs(a) / Math.Abs(b);
            Console.WriteLine(x + " " + y + " " + z + " " + k);
        }
        static void Begin12()
        {
            int a = 3;
            int b = 4;
            double c = Math.Sqrt(a * a + b * b);
            double P = a + b + c;
            Console.WriteLine(P + " " + c);
        }
        static void Begin13()
        {
            int R1 = 5;
            int R2 = 4;
            double S1 = Math.PI * R1 * R1;
            double S2 = Math.PI * R2 * R2;
            double S3 = S1 - S2;
            Console.WriteLine(S1 + " " + S2 + " " + S3);
        }
        static void Begin14()
        {
            int L = 3;
            double R = L / (Math.PI * 2);
            double S = Math.PI * R * R;
            Console.WriteLine(S);
        }
        static void Begin15()
        {
            int S = 6;
            double D = (Math.Sqrt(S / Math.PI)) * 2;
            double L = Math.PI * D;
            Console.WriteLine(D + " " + L);
        }
        static void Begin16()
        {
            int x1 = 3;
            int x2 = 4;
            double d = Math.Abs(x1 - x2);
            Console.WriteLine(d);
        }
        static void Begin17()
        {
            int xa = 0;
            int ya = 0;
            int xb = 0;
            int yb = 7;
            int xc = 4;
            int yc = 3;
            double AC = Math.Sqrt((xa - xc) * (xa - xc) - (ya - yc) * (ya - yc));
            double BC = Math.Sqrt((xb - xc) * (xb - xc) - (yb - yc) * (yb - yc));
            double S = BC + AC;
            Console.WriteLine(S);
        }
        static void Begin18()
        {
            int xa = 0;
            int ya = 4;
            int xb = 8;
            int yb = 4;
            int xc = 3;
            int yc = 4;
            double AC = Math.Sqrt((xa - xc) * (xa - xc) - (ya - yc) * (ya - yc));
            double BC = Math.Sqrt((xb - xc) * (xb - xc) - (yb - yc) * (yb - yc));
            double S = BC * AC;
            Console.WriteLine(S);
        }
        static void Begin19()
        {
            int x1 = 0;
            int x2 = 4;
            int y1 = 0;
            int y2 = 5;
            double z1 = Math.Abs(x1 - x2);
            double z2 = Math.Abs(y1 - y2);
            double S = z2 * z1;
            double P = 2*(z1 + z2);
            Console.WriteLine(S + " " + P);
        }
        static void Begin20()
        {
            int x1 = 3;
            int y1 = 4;
            int x2 = 2;
            int y2 = 7;
            double l = Math.Sqrt((x2 - x1) * (x2 - x1) - (y1 - y2) * (y1 - y2));
            Console.WriteLine(l);
        }
        static void Begin21()
        {
            int x1 = 0;
            int y1 = 0;
            int x2 = 6;
            int y2 = 0;
            int x3 = 3;
            int y3 = 3;
            double a = Math.Sqrt((x1 - x2) * (x1 - x2) - (y1 - y2) * (y1 - y2));
            double b = Math.Sqrt((x1 - x3) * (x1 - x3) - (y1 - y3) * (y1 - y3));
            double c = Math.Sqrt((x3 - x2) * (x3 - x2) - (y3 - y2) * (y3 - y2));
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine(S);
        }
        static void Begin22()
        {
            int A = 3;
            int B = 4;
            int r = B;
            B = A;
            A = r;
            Console.WriteLine(A + " " + B);
        }
        static void Begin23()
        {
            int A = 3;
            int B = 4;
            int C = 7;
            int r1 = B;
            int r2 = C;
            B = A;
            A = r2;
            C = r1;
            Console.WriteLine(A + " " + B + " " + C);
        }
        static void Begin24()
        {
            int A = 3;
            int B = 4;
            int C = 7;
            int r1 = B;
            int r2 = C;
            C = A;
            A = r1;
            B = r2;
            Console.WriteLine(A + " " + B + " " + C);
        }
        static void Begin25()
        {
            int x = 3;
            int y = 3 * (x * x * x * x * x * x) - 6 * (x * x) - 7;
            Console.WriteLine(y);
        }
        static void Begin26()
        {
            int x = 3;
            double y = 4 * Math.Sqrt(x - 3) * Math.Sqrt(x - 3) * Math.Sqrt(x - 3) - 7 * Math.Sqrt(x - 3) * (x - 3) + 2;
            Console.WriteLine(y);
        }
        static void Begin27()
        {
            int A = 3;
            int x = A * A;
            int y = x * x;
            int z = y * y;
            Console.WriteLine(x + " " + y + " " + z);
        }
        static void Begin28()
        {
            int A = 3;
            int x = A * A;
            int y = x * A;
            int z = x * y;
            int l = z * z;
            int k = l * z;
            Console.WriteLine(x + " " + y + " " + z + " " + l + " " + k);
        }
        static void Begin29()
        {
            int a = 3;
            int x = a / 180;
            double r = Math.PI * x;
            Console.WriteLine(r);
        }
        static void Begin30()
        {
            int a = 3;
            double x = a / Math.PI;
            double S = x * 180;
            Console.WriteLine(S);
        }
        static void Begin31()
        {
            int Tf = 3;
            int Tc = (Tf - 32) * 5 / 9;
            Console.WriteLine(Tc);
        }
        static void Begin32()
        {
            int Tc = 3;
            int Tf = (9 * Tc / 5) + 32;
            Console.WriteLine(Tf);
        }
        static void Begin33()
        {
            int X = 3;
            int A = 4;
            int Y = 8;
            int p = A / X;
            int s = p * Y;
            Console.WriteLine(s + " " + p);
        }
        static void Begin34()
        {
            int X = 8;
            int A = 2;
            int Y = 4;
            int B = 2;
            int p1 = A / X;
            int p2 = B / Y;
            int d = p1 / p2;
            Console.WriteLine(d);
        }
        static void Begin35()
        {
            int V = 3;
            int U = 1;
            int T1 = 4;
            int T2 = 2;
            int S = T1 * V + T2*(V - U);
            Console.WriteLine(S);
        }
        static void Begin36()
        {
            int V1 = 3;
            int V2 = 4;
            int S = 46;
            int T = 2;
            int S2 = S + T*(V1 + V2);
            Console.WriteLine(S);
        }
        static void Begin37()
        {
            int V1 = 3;
            int V2 = 4;
            int S = 46;
            int T = 2;
            int S2 = S - T*(V1 + V2);
            Console.WriteLine(S);
        }
        static void Begin38()
        {
            int A = 3;
            int B = 4;
            int x = B / A;
            Console.WriteLine(x);
        }
        static void Begin39()
        {
            int A = 3;
            int B = 4;
            int C = 7;
            double D = B * B - 4 * A * C;
            double x1 = (-B + Math.Sqrt(D)) / 2 * A;
            double x2 = (-B - Math.Sqrt(D)) / 2 * A;
            Console.WriteLine(x1 + " " + x2);
        }
        static void Begin40()
        {
            int A1 = 3;
            int B1 = 4;
            int C1 = 7;
            int A2 = 2;
            int B2 = 6;
            int C2 = 9;
            int D = A1 * B2 - A2 * C1;
            int x = (C1 * B2 - C2 * B1) / D;
            int y = (A1 * C2 - A2 * C1) / D;
            Console.WriteLine(x + " " + y);
        }
    }

}

