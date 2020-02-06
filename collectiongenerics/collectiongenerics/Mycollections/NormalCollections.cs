using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectiongenerics.Mycollections
{
    class NormalCollections
    {
        public void myArrayList()
        {
            ArrayList al;
            al = new ArrayList();
            al.Add("japan");
            al.Add("india");
            al.Add(234);
            al.Add("china");
            al.Add("singapore");
            al.Add("usa");

            Console.WriteLine("items in arraylist");
            Console.WriteLine("-----------------------");
            foreach(object o in al)
            {
                Console.WriteLine(o);
            }
            try
            {
                al.Sort();
            }
            catch(Exception exc)
            {
                Console.WriteLine("\n couldnot sort");
            }
            Console.WriteLine("\n\nafter sorting");
            Console.WriteLine("------------------------");
            foreach(object o in al)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("\n\nis india in the list?");
            Console.WriteLine("search result: "+al.Contains("india"));
        }

       
    }
}
