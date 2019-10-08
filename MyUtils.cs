using System;

namespace MyUtils
{
    public class MyUtils
    {

    }
    public static class Rnd
    {
        private static Random r;
        public static int Random50()
        {
            if (r == null) r = new Random();
            return r.Next(1, 50);
        }
        public static int Random(int min, int max)
        {
            if (r == null) r = new Random();

            return r.Next(min, max);
        }
    }
    public static class Aray
    {
        public static int[] ArayGenerate(int min, int max, int length)
        {
            int[] A = new int[length];
            for (int i = 0; i <= A.Length; i++)
            {
                A[i] = Rnd.Random(min, max);
                Console.Write(A[i] + " ");
            }
            return A;
        }
        public static void WriteArray(int[] A,int length)
        {
            for(int i=0;i<=length;i++) Console.Write(A[i] + " ");
        }
    }
}
