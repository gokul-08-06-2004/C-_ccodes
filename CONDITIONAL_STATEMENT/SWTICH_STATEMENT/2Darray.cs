using System;
namespace Example
{
    class Arrays
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8 };
            int[] c = new int[5];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = i * 2;

            }
            //int num1;
            foreach (int num1 in a)
            {
                Console.WriteLine(num1);
            }
            foreach (int num2 in b)
            {
                Console.WriteLine(num2);
            }
            foreach (int num3 in c)
            {
                Console.WriteLine(num3);
            }

            int[][] arr = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = new int[2,2];
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    arr2[i, j] = i*2;
                }
            }

            foreach(int[] d in arr)
            {
                foreach(int e in d)
                {
                    Console.WriteLine(e);
                }
            }
            foreach(int f in arr1)
            {
                Console.WriteLine(f);
            }
            foreach(int d in arr2)
            {
                Console.WriteLine(d);
            }
        }

    }
}
