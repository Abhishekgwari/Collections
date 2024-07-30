using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class DictionaryCollection
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 1);
            dt.Add("Ename", "Abhishek");
            dt.Add("Job", "Daveloper");
            dt.Add("Salary", 40000);
            dt.Add("Mgrid", 1003);
            dt.Add("Phone", "564546645");
            dt.Add("Email", "abc@gmail.com");
            dt.Add("Dname", "IT");
            dt.Add("Location", "Mumbai");
            dt.Add("Did", 30);

            foreach (var key in dt.Keys)
            

                Console.WriteLine(key + " :" + dt[key]);
                Console.ReadLine();
            

        }
    }
}
