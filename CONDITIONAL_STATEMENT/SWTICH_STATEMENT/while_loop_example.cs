using System;
namespace Example
{
    class While
    {
        static void Main()
        {
            bool isRun = true;
            int count = 0;

         while (isRun)
            {
                Console.WriteLine("running :"+count);
                Thread.Sleep(5000);//"The currently running thread should pause for 1 second."
                count = count + 1;

                if(count >=5)
                {
                    isRun = false;
                }
            }
            Console.WriteLine("total no of count =" + count);
        }
    }
}
