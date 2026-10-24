using System;
namespace program
{
    enum e { monday, tuesday, wednesday, thrusday, friday, saturday }
    enum e2 { none=0,read=1,write=2,execute=4,fullaccess = read|write|execute}

    class Demo
    {
        static void Main()
        {
            Days days = new Days();
            e e1 = (e)1;
            Console.WriteLine(e1);
            string res=days.GetDays(e1.ToString());
            Console.WriteLine(res);

            e2 e3 = e2.write | e2.read;
            bool result = (e3 & e2.write) == e2.write;

            Console.WriteLine(result);

            Console.WriteLine(e3);

            Console.WriteLine(e3.HasFlag(e2.read));
            Console.WriteLine(e3.HasFlag(e2.execute));


            //string to enum
            string name1 = "monday";
            e e4 = (e)Enum.Parse(typeof(e), name1);
            Console.WriteLine(e4);

            //enum to string
            e e5 = e.tuesday;
            string name2 = e5.ToString();
            Console.WriteLine(name2);

            //integer to enum
            e e6 = (e)1;
            Console.WriteLine(e6);

            //Enum to integer
            e e7 = e.monday;
            int num = (int)e7;
            Console.WriteLine(num);
            string name4 = "abfbibi";
            if(Enum.TryParse(name4,true,out e dir)&&Enum.IsDefined(typeof(e),name4))
            {
                Console.WriteLine($"name1:{dir}");

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
    class Days
    {

        public string GetDays(string day) =>
        day switch
        {
            "monday"=>"morvelous",
            "tuesday"=>"thankfull",
            "wednesday"=>"wounderful",
            _=>"invalid"

        };
    }
}
