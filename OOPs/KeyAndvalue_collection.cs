using System;
using System.Collections;
namespace Arr
{
    class ArrayLists
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();

            arr.Add(null);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
            for(int i=0;i<arr.Count;i++)
            {
                Console.WriteLine(arr[i]);
            }
            List<int> arr1 = new List<int>();
            arr1.Add(1);
            arr1.Add(2);
            arr1.Add(3);

            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------");
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1,2);
            hashtable.Add(2,3); 
            hashtable.Add(3,4);
           
            foreach (int i in hashtable.Values)

            {
                Console.WriteLine(i);
            }

            SortedList sortlist = new SortedList();
            sortlist.Add(1,2);
            sortlist.Add(2,3);
            sortlist.Add(3,4);

            foreach(int i in sortlist.Keys)
            {
                Console.WriteLine(sortlist[i]);
            }

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "gokul");
            dict.Add(2, "ramu");
            dict.Add(3,"arun");
            dict.Add(4, "ammu");

            foreach(var i in dict.Keys)
            {
                Console.WriteLine(i);
                Console.WriteLine(dict[i]);
            }
            Console.WriteLine(string.Join("", dict.Values));
            for(int i=0;i<10;i++)
            {
                if (dict.ContainsKey(i))
                {

                    Console.WriteLine(i);
                    if (dict.TryGetValue(i, out string result))
                    {

                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            
            }

            
        }
    }
}
