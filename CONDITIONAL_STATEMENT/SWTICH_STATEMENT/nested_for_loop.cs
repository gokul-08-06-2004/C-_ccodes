using System;
namespace Example
{
    class for_loop
    {
        static void Main()
        {
            int i, j;
            for(i=2;i<=100;i++)
            {
                for (j=2;j <= i/j;j++)//j=>square root of i,j^2 <= i => j^2<=i => j^2/j<=i/j => j<=i/j 
                {
                    if(i%j==0)
                    {
                        //Console.WriteLine("{0} is not a prime number", i);
                        break;
                    }
                   

                }
                if (j > i / j)//passed the bounbary line

                    Console.WriteLine("{0} is a prime number", i);
            }
            Console.WriteLine("------------------------------------------------------");
          
            for (i=2;i<=20;i++)
            {
                bool result = true;
                for (j=2;j*j<=i;j++)
                {
                    if(i%j==0)
                    {
                        result = false;
                        break;
                    }
                }
                if (result)
                    Console.WriteLine("{0} is a prime number", i);
            }
           
        }
    }
}
