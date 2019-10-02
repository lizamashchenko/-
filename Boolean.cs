using System;
using System.IO;

namespace ConsoleApp2
{
    class Boolean
    {
        static void Main()
        {
            Boolean3();
        }
        static bool Boolean1()
        {
            int A = 98;
            return A > 0;
        }
        static bool Boolean2()
        {
            int A = 43;
            return (A % 2) > 0;
        }
        static bool Boolean3()
        {
            int A = 234;
            return (A % 2) == 0;
        }
        static bool Boolean4()
        {
            int A = 79;
            int B = 31;
            return A > 2 && B <= 3;
        }
        static bool Boolean5()
        {
            int A = 98;
            int B = -1;
            return A >= 0 && B < -2;
        }
        static bool Boolean6()
        {
            int A = 1;
            int B = 91;
            int C = 97;
            return  B > A && B < C;
        }
        static bool Boolean7()
        {
            int A = 79;
            int B = 31;
            int C = 24;
            return B>A && B < C||B < A && B > C;
        }
        static bool Boolean8()
        {
            int A = 37;
            int B = 21;
            return A % 2 > 0 && B % 2 > 0;
        }
        static bool Boolean9()
        {
            int A = 49;
            int B = 14;
            return A % 2 > 0 || B % 2 > 0;
        }
        static bool Boolean10()
        {
            int A = 73;
            int B = 32;
            return A % 2 > 0 ^ B % 2 > 0;
        }
        static bool Boolean11()
        {
            int A = 15;
            int B = 41;
            return A % 2 > 0 && B % 2 > 0 || A % 2 == 0 && B % 2 == 0;
        }
        static bool Boolean12()
        {
            int A = 1;
            int B = 3;
            int C = 4;
            return A > 0 && B > 0 && C > 0;
        }
        static bool Boolean13()
        {
            int A = 9;
            int B = -3;
            int C = 8;
            return A > 0 || B > 0 || C > 0;
        }
        static bool Boolean14()
        {
            int A = -7;
            int B = 1;
            int C = -1;
            return A > 0 || B > 0 || C > 0;
        }
        static bool Boolean15()
        {
            int A = 9;
            int B = -31;
            int C = 5;
            return A > 0 || B > 0 || C > 0;
        }
        static bool Boolean16()
        {
            int A = 78;
            return A % 2 == 0 && A / 10 >= 0 && A / 10 <= 10;
        }
        static bool Boolean17()
        {
            int A = 792;
            return A % 2 > 0 && A / 10 >= 10 && A / 10 <= 99;
        }
        static bool Boolean18()
        {
            int A = 39;
            int B = 17;
            int C = 39;
            return A==B||A==C||C==B;
        }
        static bool Boolean19()
        {
            int A = 9;
            int B = 8;
            int C = -9;
            return A==-1*B||B==-1*C||A==-1*C;
        }
        static bool Boolean20()
        {
            int A = 438;
            int n1 = A / 100;
            int n2 = (A/10)%10;
            int n3 = A % 10;
            return n1 != n2 && n1 != n3 && n2 != n3;
        }
        static bool Boolean22()
        {
            int A = 168;
            int n1 = A / 100;
            int n2 = (A / 10) % 10;
            int n3 = A % 10;
            return n1 > n2 && n2 > n3 || n3 > n2 && n2 > n1;
        }
        static bool Boolean21()
        {
            int A = 970;
            int n1 = A / 100;
            int n2 = (A / 10) % 10;
            int n3 = A % 10;
            return n1 < n2 && n2 < n3;
        }
        static bool Boolean23()
        {
            int A = 3443;
            int n1 = A / 1000;
            int n2 = (A / 100) % 10;
            int n3 = (A /10) % 10;
            int n4 = A % 10;
            return n1 == n4 && n2 == n3;
        }
        static bool Boolean24()
        {
            int A = 2;
            int B = -4;
            int C = 10;
            double D = B*B-4*A*C;
            return D > 0;
        }
        static bool Boolean25()
        {
            int x = 7;
            int y = 8;
            return x < 0 && y > 0;
        }
        static bool Boolean26()
        {
            int x = 9;
            int y = -2;
            return x > 0 && y < 0;
        }
        static bool Boolean27()
        {
            int x = -9;
            int y = 1;
            return x < 0 && y > 0 || x < 0 && y < 0;
        }
        static bool Boolean28()
        {
            int x = 4;
            int y = -1;
            return x > 0 && y > 0 || x < 0 && y < 0;
        }
        static bool Boolean29()
        {
            int x = 7;
            int y = -11;
            int x1 = 8;
            int y1 = 7;
            int x2 = -8;
            int y2 = -3;
            return x > x2 && x < x1 && y > y1 && y < y2;
        }
        static bool Boolean30()
        {
            int a = 9;
            int b = 8;
            int c = 3;
            return a==b&&b==c;
        }
        static bool Boolean32()
        {
            int a = 9;
            int b = 8;
            int c = 3;
            return c*c==a*a+b*b||a*a==b*b+c*c||b*b==c*c+a*a;
        }
        static bool Boolean31()
        {
            int a = 9;
            int b = 9;
            int c = 3;
            return a == b || b == c||a==c;
        }
        static bool Boolean33()
        {
            int a = 7;
            int b = 1;
            int c = 3;
            return a <c + b && b < a + c && c< a + b;
        }
        static bool Boolean34()
        {
            int x = 7;
            int y = 8;
            return x % 2 == 0 && y % 2 > 0 || x % 2 > 0 && y % 2 == 0;
        }
        static bool Boolean35()
        {
            int x1 = 1;
            int y1 = 4;
            int x2 = 3;
            int y2 = 2;
            return x1 % 2 == 0 && y1 % 2 > 0 && x2 % 2 == 0 && y2 % 2 > 0 || x1 % 2 > 0 && y1 % 2 == 0 && x2 % 2 > 0 && y2 % 2 == 0 || x1 % 2 > 0 && y1 % 2 > 0 && x2 % 2 > 0 && y2 % 2 > 0 || x1 % 2 == 0 && y1 % 2 == 0 && x2 % 2 == 0 && y2 % 2 == 0;
        }
        static bool Boolean36()
        {
            int x1 = 2;
            int y1 = 4;
            int x2 = 3;
            int y2 = 5;
            return x1==x2 || y1==y2;
        }
        static bool Boolean37()
        {
            int x1 = 7;
            int y1 = 8;
            int x2 = 3;
            int y2 = 2;
            return x1 == x2 + 1 && y1 == y2 || x2 == x1 - 1 && y1 == y2 || x2 == x1 + 1 && y1 == y2 || x1 == x2 - 1 && y1 == y2 || y1 == y2 + 1 && x1 == x2 || y2 == y1 - 1 && x1 == x2 || y2 == y1 + 1 && x1 == x2 || y1 == y2 - 1 && x1 == x2;
        }
        static bool Boolean38()
        {
            int x1 = 4;
            int y1 = 8;
            int x2 = 1;
            int y2 = 4;
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
        static bool Boolean39()
        {
            int x1 = 7;
            int y1 = 1;
            int x2 = 3;
            int y2 = 3;
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2) || x1 == x2 || y1 == y2;
        }
        static bool Boolean40()
        {
            int x1 = 6;
            int y1 = 3;
            int x2 = 1;
            int y2 = 2;
            return x1 == x2 + 1 && y1 == y2 + 3 || x1 == x2 - 1 && y1 == y2 + 3 || x1 == x2 + 1 && y1 == y2 - 3 || x1 == x2 - 1 && y1 == y2 - 3 || x2 == x1 + 1 && y2 == y1 + 3 || x2 == x1 - 1 && y2 == y1 + 3 || x2 == x1 + 1 && y2 == y1 - 3 || x2 == x1 - 1 && y2 == y1 - 3;
        }
    }
}
