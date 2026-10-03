using System;
using System.Collections.Generic;
using System.IO.Pipes;
namespace List
{
    class Fruits
    {
        static void Main()
        {
            //List
            List<int> num = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            List<int> num1 = new List<int>();
            int mul = 3;
            for (int i = 0; i <= 10; i++)
            {
                num1.Add(mul * i);
            }
            foreach (int i in num1)
            {
                Console.WriteLine(i);
            }
            //Dirtionaries
            Dictionary<int, string> stu = new Dictionary<int, string> { { 1, "gokul" }, { 2, "vijay" }, { 3, "ravi" } };

            foreach (KeyValuePair<int, string> student in stu)
            {
                Console.WriteLine($"id{student.Key},name{student.Value}");
            }

            List<Person> person = new List<Person> { new Person { Id =20,Name ="gokul"},new Person { Id =30,Name="ram"}  };

            foreach(var persons in person)
            {
                persons.Id =persons.Id+ 1;
                Console.WriteLine($"Id:{persons.Id}| Name:{persons.Name}");
            }

        
        }

    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
