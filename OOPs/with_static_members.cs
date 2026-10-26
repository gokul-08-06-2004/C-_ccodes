using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace Program
{
    class Demo
    {
        //with static 
        public static int num;
        
        public void setvalue()
        {
            num += 1;
            Console.WriteLine(num);
        }

       public static int getvalue()
        {
            return num;
        }
        static void Main()
        {
            Demo demo=new Demo();
            Demo demo1 = new Demo();
            demo.setvalue();
            demo.setvalue();
            demo.setvalue();
            demo1.setvalue();
            demo1.setvalue();
            Console.WriteLine(Demo.getvalue());
           
        }
    }
}
