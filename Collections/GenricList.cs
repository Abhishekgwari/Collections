using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenricList
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(40);
            li.Add(60);
            li.Add(50);
            li.Add(20);
            li.Add(30);

            li.Sort();

            for (int i = 0; i < li.Count; i++)

                Console.WriteLine(li[i] + " ");
            Console.WriteLine();


            li.Insert(3, 35);
            foreach (int i in li)
                Console.WriteLine(i);


            li.RemoveAt(1);
            foreach (int i in li)
                Console.WriteLine(i);

            Console.ReadLine();

        }
    }
}
