using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generics1                      //Generic method
    {
        public bool Compare<T>(T a,T b)
        {
            if(a.Equals(b))
                return true;
            return false;
        }

        
        static void Main(string[] args)
        {
            Generics1 obj = new Generics1();
             bool result = obj.Compare<float>(23.46f, 45.51f);
            Console.WriteLine(result);

            bool result2 = obj.Compare<int>(10, 10);
            Console.WriteLine(result2);

        }
    }
}
