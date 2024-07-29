using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList  al = new ArrayList(2);
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);al.Add(300); al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);

            foreach(object obj in al)
                Console.WriteLine(obj + " ");

            al.Insert(3, 350);                        // Adding item between array
            foreach (object obj in al)
                Console.WriteLine(obj + " ");
           

          //  al.Remove(200);                  // Removing item from array
            al.RemoveAt(1);                   // Removing item using  index no
            foreach (object obj in al)
                Console.WriteLine(obj + " ");
            Console.ReadLine();
        }
    }
}
