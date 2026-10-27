using System;
using System.Reflection.PortableExecutable;
namespace Program
{
    interface IInspect
    {
        void Machine();

        int setvalue(int arr);
    }
    class base_class
    {
        public int num;
        public int num2;
        public int num3;
        public base_class(int num2,int num3)
        {
            this.num2 = num2;
            this.num3 = num3;
        }
        public virtual void Machine()
        {
            num = 2 * 4;
            Console.WriteLine($"before override:{num}");
        }
        

    }
     class derived_class:base_class,IInspect
    {
        int roll_no;
        public derived_class(int roll_no,int num2,int num3):base(num2,num3)
        {
            this.roll_no = roll_no;
        }
        public override void Machine()
        {
            num = 3 * 4;
            
            Console.WriteLine($"after override:{num} {roll_no} {num2} {num3}");
        }
        public int setvalue(int num)
        {
            this.num = num;
            return num;
        }
        static void Main()
        {
            derived_class d = new derived_class(23,24,34);
            Console.WriteLine(d.setvalue(23));
            d.Machine();
        }
    }
}
