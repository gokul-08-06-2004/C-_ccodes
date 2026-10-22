using System;
namespace Program
{
    class Priority_based
    {
        static void Main(string[] args)
        {
            Stack<int> stack=new Stack<int>();//LIFO
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("--------------");
            Queue<int> queue=new Queue<int>();//FIFO
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            while(queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            File.WriteAllText("text.txt", "hellow goo morining");
            string content = File.ReadAllText("text.txt");
            Console.WriteLine(content);
        }
    }
}
