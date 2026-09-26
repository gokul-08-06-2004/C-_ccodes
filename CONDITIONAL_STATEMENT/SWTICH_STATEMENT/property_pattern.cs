using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
namespace property_pattern
{
    class Example
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        static void Main()
        {
            Name name = new Name { Value1 = "gooul", Value2 = "ram", Value3 = "hari" };
            Name name1 = new Name { Value1 = "gooul", Value2 = "ram", Value3 = "hari" };
            Example names= new Example { Value4 = "gooul", Value2 = "ram", Value3 = "hari" };
            string result2 =Numbers(names);
            bool result = name.Numbers(name);
            bool result1 = name1.Number(name1);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
           
        }
        public static string Numbers(Example names) =>

            names switch
            {
                Example { Value1: string value1, Value2: string value2, Value3: string value3 } => $"{value1},{value2},{value3}",
                _ => "Invalid"

            };
    }
    class Name
    {
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public bool Numbers(Name name) =>
            name is { Value1: "gooul", Value2: "ram", Value3: "hari" };
        public bool Number(Name name1) =>
            name1 is { Value1: "ravi", Value2: "ram", Value3: "hari" };


    }
}