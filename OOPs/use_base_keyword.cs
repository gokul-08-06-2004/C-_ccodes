using System;
using System.Reflection.Metadata;
namespace Program
{
    class base_class
    {
        public int width,heigth;
        public string name;
        public base_class(string machinename)
        {
            name = machinename;
            Console.WriteLine(name);
        }
        public void Width(int w)
        {
            width = w;
        }
        public void Height(int h)
        {
            heigth = h;
        }

    }
    class derived_class:base_class
    {
        public string name1;
        public derived_class(string machinename):base(machinename)
        {
            name1= machinename;
            Console.WriteLine(name1);
        }
        public int getArea()
        {
            return width * heigth;
        }
        static void Main()
        {
            derived_class d = new derived_class("umpt2");
            d.Width(2);
            d.Height(2);
            int res =d.getArea();
            Console.WriteLine(res);        
        }
    }

}
