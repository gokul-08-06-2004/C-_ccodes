using System;
using System.Runtime.CompilerServices;
namespace program
{
    class Static_polymorphism
    {
        public int index;
        public bool Ack;
        int num;
        public double print(int index)
        {
            this.index = index++;
            return index;
        }
        public int[] print(int index, int num)
        {
            this.index = index++;
            this.num = num;
            return new int[] { index, num };

        }
        public bool print(bool Ack)
        {
            this.Ack = Ack;
            return Ack;
        }

        public int a, b;
        public int Sum(int a, int b)
        {
            return a + b;
        }


        static void Main()
        {
            Static_polymorphism sta = new Static_polymorphism();

            int[] arr = sta.print(23, 24);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"{sta.print(34)},{sta.print(true)}");

            int res = sta.Sum(2, 3);
            Box b1 = new Box(10);
            b1.Display();
            Box b2 = new Box(20);
            b2.Display();
            Box result = b1.Demo(b2);
            result.Display();
            Box ress = b1 + b2;
            ress.Display();
        }
        class Box
        {
            public int chcolates;

            public Box(int count)
            {
                chcolates = count;
            }
            public int Volume()
            {
                return chcolates;
            }
            public Box Demo(Box other)
            {
                return new Box(this.chcolates + other.chcolates);
            }
            public static Box operator +(Box a, Box b)
            {
                return new Box(a.chcolates + b.chcolates);
            }
            public void Display()
            {
                Console.WriteLine(chcolates);
            }
        }
    }
}
