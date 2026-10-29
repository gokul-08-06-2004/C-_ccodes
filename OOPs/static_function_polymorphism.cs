using System;
namespace program
{
    class Static_polymorphism
    {
        public int index;
        public bool Ack;
        int num;
        public double print(int index)
        {
            this.index=index++;
            return index;
        }
        public int[] print(int index,int num)
        {
            this.index=index++;
            this.num = num;
            return new int[]{index,num};
            
        }
        public bool print(bool Ack)
        {
            this.Ack = Ack;
            return Ack;
        }
        static void Main()
        {
            Static_polymorphism sta =new Static_polymorphism();

            int[] arr = sta.print(23, 24);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"{sta.print(34)},{sta.print(true)}");
        } 
    }
}
