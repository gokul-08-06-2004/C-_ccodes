using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace Program
{
    class Demo
    {
        //without static 
        public int num;
        
        public void setvalue()
        {
            num += 1;
            Console.WriteLine(num);
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
            
        }
    }
}
