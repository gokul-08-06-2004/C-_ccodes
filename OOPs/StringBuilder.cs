using System;
using System.Text;
namespace StringApplication
{
    class StringProg
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            if (string.Compare(str1, str2) == 0)
            {
                Console.WriteLine("Strings are equal.");
            }
            else
            {
                Console.WriteLine("Strings are not equal.");
            }

            string str3 = str1 + str2;

            string str4 = str3.Substring(0, 5);
            Console.WriteLine(str4);

            if(str3.Contains("wo"))
            {
                Console.WriteLine(str3);
            }
            else
            {
                Console.WriteLine("invlaid");
            }
            char[] ch = { 'e', 'r', 't' };
            string str5 = string.Join("", ch);
            Console.WriteLine(str5);

            //string Builder
            StringBuilder sb = new StringBuilder("GOkul");

            sb.Append("good");
            sb.Insert(3, "ee");
            sb.Replace("ee", "ff");
            Console.WriteLine(sb);

            string str6="oenrwoibgo";

            object obj = str6.Clone();
            string str7 = (string)str6.Clone();

            Console.WriteLine(ReferenceEquals(str6, obj));




        }

    }
}
