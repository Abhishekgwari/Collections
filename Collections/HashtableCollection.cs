using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashtableCollection
                 // Hashtable is also like  araylist  but  it stores data in  key/value Combination  keys are user define
    
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",1);     
            ht.Add("Ename","Abhishek");
            ht.Add("Job","Daveloper");
            ht.Add("Salary", 40000);
            ht.Add("Mgrid", 1003);
            ht.Add("Phone","564546645");
            ht.Add("Email","abc@gmail.com");
            ht.Add("Dname","IT"); 
            ht.Add("Location", "Mumbai");
            ht.Add("Did",30);


            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key +":" + ht[key]);
            }

           
           Console.ReadLine();

        }


    }
}
