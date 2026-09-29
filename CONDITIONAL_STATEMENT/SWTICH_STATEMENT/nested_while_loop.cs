using System;
namespace Example
{
    class While_loop
    {
        static void Main()
        {
            int i = 2;

            while(i<100)
            {
                int j = 2;
                while (j<=i/j)
                {
                    if(i%j==0)
                    {
                        break;
                    }
                    
                    j++;


                }
                if(j>i/j)
                {
                    Console.WriteLine("{0} is a prime number ", i);
                }
                
                i++;
            }
        }
    }
}
