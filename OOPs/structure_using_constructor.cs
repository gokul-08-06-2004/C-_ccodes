using System;
namespace Program
{
    struct str
    {
        public string Name;
        public int age;
        int phone_number;
        bool Male;
        double salary;

        public str(string Name,int age,int phone_number,bool Male,double salary)
        {
            this.Name = Name;
            this.age = age;
            this.phone_number = phone_number;
            this.Male = Male;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Name:{Name}|Age:{age}|phone_nnumber:{phone_number},Male:{Male},salary:{salary}");
        }
    }
    class Structure
    {
        static void Main()
        {
            str s =new str("gokul",22,123456,true,100000000.00);
            s.Display();
            str s1 = new str();
            s1.Display();
            str s2 ;
            s2.Name = "ram";
            Console.WriteLine($"{s2.Name}");
        }
    }
}
