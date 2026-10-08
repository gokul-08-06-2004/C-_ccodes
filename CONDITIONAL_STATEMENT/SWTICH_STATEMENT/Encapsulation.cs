using System;
using ConsoleApp5;
namespace example
{
   
    public class main
    {
        static void Main()
        {

            demo d = new demo();

           
           

            remo r = new remo();
            r.SetValue("gokul");
            r.Display();
          

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class demo
    {

        protected string Name;

        public void SetValue(string name)
        {
            this.Name = name;
        }
        protected string getvalue()
        {
            return Name;
        }


    }

    public class remo:demo
    {
       public void Display()
        {
            Console.WriteLine(getvalue());
        }
    }
   

}
