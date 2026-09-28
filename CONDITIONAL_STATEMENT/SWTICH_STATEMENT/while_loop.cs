using System;
namespace while_loop
{
    class Example
    {
        static void Main()
        {
            //int num = 12345;
            //int count = 0;
            //while (num>0)
            //{
            //    num = num / 10;
            //    count++;
            //    Console.WriteLine(num);

            //}
            //Console.WriteLine("easghfg"+count);

            //while (num>0)
            //{
            //    int digit = num % 10;
            //    count = count * 10 + digit;
            //    num = num / 10;
            //}
            //Console.WriteLine(count);

            //int number = 12345;
            //int counter = 0;

            //while (number>0)
            //{
            //    int digit = number % 10;
            //    counter = counter + digit;
            //    number = number / 10;
            //}
            //Console.WriteLine(counter);

            int num = 12345;
            string name = num.ToString();
            int count = 0;
            for (int i =0; i<name.Length;i++)
            {
                count = count + (name[i] - '0');

            }
            Console.WriteLine(count);


            //bool machineRunning = true;

            //while (machineRunning)
            //{
            //    Console.WriteLine("Check sensor");
            //}

            int nums = 1;

            while (nums != 0)
            {
                Console.Write("enter the number :");
                nums = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(nums);

                 
        }
    }
}
