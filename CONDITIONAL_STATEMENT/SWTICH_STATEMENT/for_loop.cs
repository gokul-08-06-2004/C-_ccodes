using System;
namespace number
{
    class Example
    {
        static void Main()
        {

            int sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);

            string str = "hellow world";
            char ch = 'o';
            int times = 0;

            for (int i = 0; i < str.Length; i += 1)
            {
                if (str[i] == ch)
                {
                    times++;
                }

            }
            Console.WriteLine($"{str} :appers{times}times");

            //Factorial = 120
            int Factorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                Factorial = Factorial * i;
                if (Factorial == 120)
                    Console.WriteLine(Factorial);

            }

            int[] arr = { 10, 20, 60, 40, 50 };

        
            int largest_no = arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                
                if (arr[i] > largest_no) 
                {
                    largest_no = arr[i];
                }
            }
            Console.WriteLine(largest_no);

            for(int i=0;i<4;i++)
            {
                for (int j=0;j<4;j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine($"\n");
            }

            for(int i=0;i<5; i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine($"\n");
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine($"\n");
            }

            for (int i= 1;i<=5;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i );
                }
                Console.WriteLine($"\n");
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write($"{j}\t");
                }
                Console.WriteLine($"\n");
            }
            Console.WriteLine("bdbviefbiuqbrvqb");

            int num = 0;
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    num = num + 1;
                    Console.Write($"{num}\t");
                }
                Console.WriteLine($"\n");
            }

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine($"\n");
            }

            for (int i = 0; i < 5; i++)
            {
                for(int j=4;j>i;j--)
                {
                    Console.Write(" ");
                }
                for(int k =0;k<=i;k++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine($"\n");
            }

            for(int i = 4;i>0;i--)
            {
                for(int j=i;j<5;j++)
                {
                    Console.Write(" ");
                }
                for(int k = i;k>0;k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine($"\n");
            }
        }
    }
}