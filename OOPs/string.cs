using System;
namespace Program
{
    class String_arr
    {
        static void Main()
        {
            string name, name1;
            name = "gokul";
            name1 = "krishna";
            int num = 23;
            var fullname = name + name1+num;
            Console.WriteLine(fullname);
            Console.WriteLine("{0}", fullname);
            char[] let = { 's', 'd', 'f' };
            foreach(char i in let)
            {
                Console.WriteLine(i);
            }
            bool bnum = true;
            int[] arr = { 1, 2, 3, 4 };
            string[] str = { "gokil", "jnifsd", "ibwriufbw" };
            Console.WriteLine(string.Join("\t", str));
            while (bnum)
            {
                if(bnum)
                    Console.WriteLine(let);
                bnum=false;
            }
            bnum = false;
            bool bnum1 = true;
            while (bnum1)
            {
                if(bnum1)
                {
                    foreach(var i in str)
                    Console.WriteLine(i);
                    
                }
                bnum1 = false;
            }
            bnum1 = false;

            DateTime date = new DateTime(2026,10,10,17,23,1);
            string baseDate = DateTime.Today.ToString("yyyy-MM-dd");
            string format = string.Format("time:{0:t} on date:{0:D}", date);
            Console.WriteLine($"{format}:{baseDate}");

            //Compare string:

            string name2 = "gokul";
            string name3 = "goku";

            bool result = string.Compare(name2, name3)==0;

            if(result)
            {
                Console.WriteLine("string is equal");
            }
            else
            {
                Console.WriteLine("string is not equal");
            }

            string str1 = "ramu is good boy";
            if(str.Contains("good"))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            string res = str1.Substring(0, 5);
            Console.WriteLine(res);
            string[] arr3 = { "ramu", "gokul", "rem" };
            string res2 = string.Join(" ", arr3);
            Console.WriteLine(res2);
        }
    }
}
