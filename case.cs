using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class Program
    {
        static void Main()
        {
        }
        static void Case1()
        {
            int x = 7;
            switch (x)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Воскресение");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case2()
        {
            int K = 2;
            switch (K)
            {
                case 1:
                    Console.WriteLine("Плохо");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case3()
        {
            int x = 3;
            switch (x)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case4()
        {
            int x = 11;
            switch (x)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine("29");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;

            }
        }
        static void Case5()
        {
            int N = 5;
            int A = 7;
            int B = 8;
            int y = 0;
            switch (N)
            {
                case 1:
                    y = A + B;
                    break;
                case 2:
                    y = A - B;
                    break;
                case 3:
                    y = A * B;
                    break;
                case 4:
                    y = A / B;
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case6()
        {
            int x = 67;
            int N = 3;
            double y = 0;
            switch (N)
            {
                case 1:
                    y = x * 0.1;
                    break;
                case 2:
                    y = x * 1000;
                    break;
                case 3:
                    y = x;
                    break;
                case 4:
                    y = x * 0.001;
                    break;
                case 5:
                    y = x * 0.01;
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case7()
        {
            int x = 5;
            int N = 2;
            double y = 0;
            switch (N)
            {
                case 1:
                    y = x;
                    break;
                case 2:
                    y = x * 0.001;
                    break;
                case 3:
                    y = x * 0.01;
                    break;
                case 4:
                    y = x * 100;
                    break;
                case 5:
                    y = x * 1000;
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case8()
        {
            int D = 5;
            int M = 6;
            switch (D)
            {
                case 1:
                    if (M == 1)
                    {
                        M = 12;
                    }
                    else
                    {
                        M = M - 1;
                    }
                    if (M == 1 || M == 3 || M == 5 || M == 7 || M == 8 || M == 10 || M == 12)
                    {
                        D = 31;
                    }
                    else if (M == 2)
                    {
                        D = 29;
                    }
                    else
                    {
                        D = 30;
                    }
                    break;
                default:
                    if (M == 1)
                    {
                        M = 12;
                    }
                    else
                    {
                        M = M - 1;
                    }
                    D = D - 1;
                    break;
            }
        }
        static void Case10()
        {
            int C = 3;
            int N = 2;
            switch (N)
            {
                case 1:
                    switch (C)
                    {
                        case 1:
                            Console.WriteLine("С");
                            break;
                        case 2:
                            Console.WriteLine("В");
                            break;
                        case 3:
                            Console.WriteLine("Ю");
                            break;
                        case 4:
                            Console.WriteLine("З");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 2:
                    switch (C)
                    {
                        case 1:
                            Console.WriteLine("З");
                            break;
                        case 2:
                            Console.WriteLine("С");
                            break;
                        case 3:
                            Console.WriteLine("В");
                            break;
                        case 4:
                            Console.WriteLine("Ю");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 3:
                    switch (C)
                    {
                        case 1:
                            Console.WriteLine("В");
                            break;
                        case 2:
                            Console.WriteLine("Ю");
                            break;
                        case 3:
                            Console.WriteLine("З");
                            break;
                        case 4:
                            Console.WriteLine("С");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case11()
        {
            int C = 1;
            int N1 = 2;
            int N2 = 3;
            switch (N1)
            {
                case 1:
                    switch (C)
                    {
                        case 1:
                            C = 4;
                            break;
                        case 2:
                            C = 3;
                            break;
                        case 3:
                            C = 2;
                            break;
                        case 4:
                            C = 1;
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case -1:
                    switch (C)
                    {
                        case 1:
                            C = 2;
                            break;
                        case 2:
                            C = 3;
                            break;
                        case 3:
                            C = 4;
                            break;
                        case 4:
                            C = 1;
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 2:
                    switch (C)
                    {
                        case 1:
                            C = 3;
                            break;
                        case 2:
                            C = 4;
                            break;
                        case 3:
                            C = 1;
                            break;
                        case 4:
                            C = 2;
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            switch (N2)
            {
                case 1:
                    switch (C)
                    {
                        case 1:
                            Console.WriteLine("В");
                            break;
                        case 2:
                            Console.WriteLine("Ю");
                            break;
                        case 3:
                            Console.WriteLine("З");
                            break;
                        case 4:
                            Console.WriteLine("С");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 2:
                    switch (C)
                    {
                        case 1:
                            Console.WriteLine("З");
                            break;
                        case 2:
                            Console.WriteLine("Ю");
                            break;
                        case 3:
                            Console.WriteLine("В");
                            break;
                        case 4:
                            Console.WriteLine("С");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                case 3:
                    switch (C)
                    {
                        case 1:
                            Console.WriteLine("Ю");
                            break;
                        case 2:
                            Console.WriteLine("З");
                            break;
                        case 3:
                            Console.WriteLine("С");
                            break;
                        case 4:
                            Console.WriteLine("В");
                            break;
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
        static void Case12()
        {
            int x = 3;
            int y = 3;
            double R = 1;
            double D = 1;
            double L = 1;
            double S = 1;
            switch (x)
            {
                case 1:
                    R = y;
                    D = 2 * R;
                    L = Math.PI * D;
                    S = Math.PI * R * R;
                    break;
                case 2:
                    D = y;
                    R = D / 2;
                    L = Math.PI * D;
                    S = Math.PI * R * R;
                    break;
                case 3:
                    L = y;
                    D = L / Math.PI;
                    R = D / 2;
                    S = Math.PI * R * R;
                    break;
                case 4:
                    S = y;
                    R = Math.Sqrt(S / Math.PI);
                    D = 2 * R;
                    L = Math.PI * D;
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.WriteLine(R + " " + D + " " + S + " " + L);
        }
        static void Case13()
        {
            int x = 2;
            int y = 5;
            double a = 1;
            double c = 1;
            double h = 1;
            double S = 1;
            switch (x)
            {
                case 1:
                    a = y;
                    c = Math.Sqrt(2) * a;
                    h = c / 2;
                    S = c * h / 2;
                    break;
                case 2:
                    c = y;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    S = h * c / 2;
                    break;
                case 3:
                    h = y;
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    S = c * h / 2;
                    break;
                case 4:
                    S = y;
                    c = 2 * Math.Sqrt(S);
                    h = c / 2;
                    a = c / Math.Sqrt(2);
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.WriteLine(a + " " + c + " " + h + " " + S);
        }
        static void Case14()
        {
            int x = 2;
            int y = 4;
            double a = 1;
            double R1 = 1;
            double R2 = 1;
            double S = 1;
            switch (x)
            {
                case 1:
                    a = y;
                    R1 = a * Math.Sqrt(3) / 6;
                    R2 = 2 * R1;
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 2:
                    R1 = y;
                    R2 = R1 * 2;
                    a = 6 * R1 / Math.Sqrt(3);
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 3:
                    R2 = y;
                    R1 = R2 / 2;
                    a = 6 * R1 / Math.Sqrt(3);
                    S = a * a * Math.Sqrt(3) / 4;
                    break;
                case 4:
                    S = y;
                    a = Math.Sqrt(S * 4 / Math.Sqrt(3));
                    R1 = a * Math.Sqrt(3) / 6;
                    R2 = 2 * R1;
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.WriteLine(a + " " + R1 + " " + R2 + " " + S);
        }
        static void Case15()
        {
            int M = 2;
            int N = 8;
            switch (N)
            {
                case 6:
                    Console.WriteLine("Шесть ");
                    break;
                case 7:
                    Console.WriteLine("Семь ");
                    break;
                case 8:
                    Console.WriteLine("Восемь ");
                    break;
                case 9:
                    Console.WriteLine("Девять ");
                    break;
                case 10:
                    Console.WriteLine("Десять ");
                    break;
                case 11:
                    Console.WriteLine("Валет ");
                    break;
                case 12:
                    Console.WriteLine("Дама ");
                    break;
                case 13:
                    Console.WriteLine("Король ");
                    break;
                case 14:
                    Console.WriteLine("Туз ");
                    break;
            }
            switch (M)
            {
                case 1:
                    Console.WriteLine("пик");
                    break;
                case 2:
                    Console.WriteLine("треф");
                    break;
                case 3:
                    Console.WriteLine("бубн");
                    break;
                case 4:
                    Console.WriteLine("червей");
                    break;

            }
        }
        static void Case19()
        {
            int y = 2079;
            int y1 = (y - 1984) / 60;
            int z1 = y1 / 12;
            int z2 = y1 % 12;
            switch (z1)
            {
                case 1:
                    Console.WriteLine("Год зеленого ");
                    break;
                case 2:
                    Console.WriteLine("Год красного ");
                    break;
                case 3:
                    Console.WriteLine("Год желтого ");
                    break;
                case 4:
                    Console.WriteLine("Год белого ");
                    break;
                case 5:
                    Console.WriteLine("Год черного ");
                    break;
            }
            switch (z2)
            {
                case 1:
                    Console.WriteLine("крысы");
                    break;
                case 2:
                    Console.WriteLine("коровы");
                    break;
                case 3:
                    Console.WriteLine("тигра");
                    break;
                case 4:
                    Console.WriteLine("зайца");
                    break;
                case 5:
                    Console.WriteLine("дракона");
                    break;
                case 6:
                    Console.WriteLine("змеи");
                    break;
                case 7:
                    Console.WriteLine("лошади");
                    break;
                case 8:
                    Console.WriteLine("овцы");
                    break;
                case 9:
                    Console.WriteLine("обезьяны");
                    break;
                case 10:
                    Console.WriteLine("курицы");
                    break;
                case 11:
                    Console.WriteLine("собаки");
                    break;
                case 0:
                    Console.WriteLine("свиньи");
                    break;
            }

        }
    }
}
