using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
        }
        static void If1()
        {
            int x = 7;
            if(x > 0)
            {
                x = x + 1;
            }
            Console.WriteLine(x);
        }
        static void If2()
        {
            int x = 7;
            if (x > 0)
            {
                x = x + 1;
            }
            else if (x < 0)
            {
                x = x - 2;
            }
            Console.WriteLine(x);
        }
        static void If3()
        {
            int x = 7;
            if (x > 0)
            {
                x = x + 1;
            }
            else if(x == 0)
            {
                x = 10;
            }
            else
            {
                x = x - 2;
            }
            Console.WriteLine(x);
        }
        static void If4()
        {
            int x = 7;
            int y = 3;
            int z = 8;
            int k = 6;
            int i = 0;
            if (x > 0)
            {
                i = i + 1;
            }
            if (y > 0)
            {
                i = i + 1;
            }
            if (z > 0)
            {
                i = i + 1;
            }
            if (k > 0)
            {
                i = i + 1;
            }
            Console.WriteLine(i);
        }
        static void If5()
        {
            int x = -4;
            int y = 32;
            int z = -20;
            int k = 3;
            int i1 = 0;
            int i2 = 0;
            if (x > 0)
            {
                i1 = i1 + 1;
            }
            else if (x < 0)
            {
                i2 = i2 + 1;
            }
            if (y > 0)
            {
                i1 = i1 + 1;
            }
            else if (y < 0)
            {
                i2 = i2 + 1;
            }
            if (z > 0)
            {
                i1 = i1 + 1;
            }
            else if (z < 0)
            {
                i2 = i2 + 1;
            }
            if (k > 0)
            {
                i1 = i1 + 1;
            }
            else if (k < 0)
            {
                i2 = i2 + 1;
            }
            Console.WriteLine(i1 + " " + i2);
        }
        static void If6()
        {
            int x = 5;
            int y = 45;
            if(x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
        }
        static void If7()
        {
            int x = -6;
            int y = 9;
            if (x > y)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
        static void If8()
        {
            int x = 5;
            int y = 45;
            if (x > y)
            {
                Console.WriteLine(x + " " + y);
            }
            else
            {
                Console.WriteLine(y + " " + x);
            }
        }
        static void If9()
        {
            int A = 7;
            int B = -2;
            if (A > B)
            {
                int res = A;
                A = B;
                B = res;
            }
            Console.WriteLine(A + " " + B);
        }
        static void If10()
        {
            int A = 7;
            int B = -2;
            if (A != B)
            {
                A = A + B;
                B = A + B;
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine(A + " " + B);
        }
        static void If11()
        {
            int A = 7;
            int B = -2;
            if (A != B)
            {
                if(A > B)
                {
                    B = A;
                }
                else
                {
                    A = B;
                }
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine(A + " " + B);
        }
        static void If12()
        {
            int x = 7;
            int y = -2;
            int z = 90;
            if (x < y && x < z)
            {
                Console.WriteLine(x);
            }
            else if (y < x && y < z) 
            {
                Console.WriteLine(y);
            }
            else if (z < x && z < y)
            {
                Console.WriteLine(z);
            }
        }
        static void If13()
        {
            int x = 7;
            int y = -2;
            int z = 90;
            if (x < y && x > z)
            {
                Console.WriteLine(x);
            }
            else if (y < x && y > z)
            {
                Console.WriteLine(y);
            }
            else if (z < x && z > y)
            {
                Console.WriteLine(z);
            }
            else if (x > y && x < z)
            {
                Console.WriteLine(x);
            }
            else if (y > x && y < z)
            {
                Console.WriteLine(y);
            }
            else if (z > x && z < y)
            {
                Console.WriteLine(z);
            }
        }
        static void If14()
        {
            int x = 7;
            int y = 6;
            int z = 90;
            int min = 0;
            int max = 0;
            if (x < y && x < z)
            {
                min = x;
            }
            else if (y < x && y < z)
            {
                min = y;
            }
            else
            {
                min = z;
            }
            if (x > y && x > z)
            {
                max = x;
            }
            else if (y > x && y > z)
            {
                max = y;
            }
            else
            {
                max = z;
            }
            Console.WriteLine(min + "  " + max);
        }
        static void If15()
        {
            int x = 6;
            int z = -9;
            int y = 34;
            int s = 0;
            if (x > y && y > z)
            {
                s = x + y;
            }
            else if (x > y && y < z)
            {
                s = x + z;
            }
            else if (x < y && z > x)
            {
                s = z + y;
            }
            Console.WriteLine(s);
        }
        static void If16()
        {
            int A = -6;
            int B = 9;
            int C = 8;
            if (A > B & B > C)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
            }
            else
            {
                A = -1 * A;
                B = -1 * B;
                C = -1 * C;
            }
            Console.WriteLine(A + " " + B + " " + C);
        }
        static void If17()
        {
            int A = -6;
            int B = 9;
            int C = 98;
            if (A > B && B > C||A < B && B < C)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
            }
            else
            {
                A = -1 * A;
                B = -1 * B;
                C = -1 * C;
            }
            Console.WriteLine(A + " " + B + " " + C);
        }
        static void If18()
        {
            int x = -6;
            int y = 9;
            int z = 9;
            if (x != y && x != z)
            {
                Console.WriteLine("1");
            }
            else if(y != z && y != x)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
        }
        static void If19()
        {
            int x = 3;
            int y = 9;
            int z = 3;
            int k = 3;
            if (x != y && x != z)
            {
                Console.WriteLine("1");
            }
            else if (y != z && y != x)
            {
                Console.WriteLine("2");
            }
            else if(z !=x && z != y)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }
        }
        static void If20()
        {
            int xa = -6;
            int ya = 9;
            int xb = 6;
            int yb = 9;
            int xc = 3;
            int yc = 9;
            double AB = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
            double AC = Math.Sqrt((xa - xc) * (xa - xc) + (ya - yc) * (ya - yc));
            if (AB > AC)
            {
                Console.WriteLine("(" + xb + ";" + yb + ")" + AB);
            }
            else
            {
                Console.WriteLine("(" + xc + ";" + yc + ")" + AC);
            }
        }
        static void If21()
        {
            int x = -6;
            int y = 9;
            if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            }
            else if(x == 0)
            {
                Console.WriteLine("1");
            }
            else if (y == 0)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
        }
        static void If22()
        {
            int x = -6;
            int y = 9;
            if (x > 0 && y > 0) 
            {
                Console.WriteLine("1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }
            else
            {
                Console.WriteLine("4");
            }
        }
        static void If23()
        {
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 4;
            int z1 = 9;
            int z2 = 4;
            int k1 = 0;
            int k2 = 0;
            if (x1 == y1)
            {
                k1 = z1;
            }
            else if (x1 == z1)
            {
                k1 = y1;
            }
            else
            {
                k1 = x1;
            }
            if (x2 == y2)
            {
                k2 = z2;
            }
            else if (x2 == z2)
            {
                k2 = y2;
            }
            else
            {
                k2 = x2;
            }
            Console.WriteLine(k1 + " " + k2);
        }
        static void If24()
        {
            double x = 0.123;
            double f = 0;
            if (x > 0)
            {
                f = Math.Sin(x) * 2;
            }
            else
            {
                f = 6 - x;
            }
            Console.WriteLine(f);
        }
        static void If27()
        {
            int x = 5;
            int f = 0;
            if (x < 0)
            {
                f = 0;
            }
            else if (x >= 0 && x < 1 && x >= 2 && x < 3)
            {
                f = 1;
            }
            else
            {
                f = -1;
            }
            Console.WriteLine(f);
        }
        static void If25()
        {
            int x = -6;
            int f = 0;
            if (x < -2 || x > 2)
            {
                f = 2 * x;
            }
            else
            {
                f = -3 * x;
            }
            Console.WriteLine(f);
        }
        static void If26()
        {
            int x = -6;
            int f = 0;
            if (x <= 0)
            {
                f = -1 * x;
            }
            else if (x > 0 && x < 2)
            {
                f = x * x;
            }
            else
            {
                f = 4;
            }
            Console.WriteLine(f);
        }
        static void If28()
        {
            int x = 1989;
            if (x / 100 == 0 && x / 400 !=0)
            {
                Console.WriteLine("365");
            }
            else if (x / 4 == 0)
            {
                Console.WriteLine("366");
            }
        }
        static void If29()
        {
            int x = 98;
            if (x == 0 )
            {
                Console.WriteLine("Нулевое число");
            }
            else if(x > 0)
            {
                Console.WriteLine("Положительное");
            }
            else
            {
                Console.WriteLine("Отрицательное");
            }
            if (x / 2 == 0)
            {
                Console.WriteLine(" четное число");
            }
            else
            {
                Console.WriteLine(" нечетное число");
            }
        }
        static void If30()
        {
            int x = 67;
            if (x / 2 == 0)
            {
                Console.WriteLine("Четное ");
            }
            else
            {
                Console.WriteLine("Нечетное ");
            }
            if (x / 10 < 1)
            {
                Console.WriteLine("однозначное число");
            }
            else if (x / 10 >= 1 && x / 10 <= 10)
            {
                Console.WriteLine("двузначное число");
            }
            else
            {
                Console.WriteLine("трехзначное число");
            }

        }

    }
}
