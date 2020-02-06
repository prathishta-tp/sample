using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace collectiongenerics.Mycollections
{
    class GenericCollections
    {
       /* public void MyList()
        {
            List<string> al = new List<string>();
            al.Add("japangeneric");
            al.Add("india");
            //al.Add(234);//compilation error
            al.Add("china");
            al.Add("singapore");
            al.Add("usa");

            Console.WriteLine("items in generic list");
            Console.WriteLine("---------------------------------");
            foreach (string s1 in al)
            {
                Console.WriteLine(s1);
            }

            try
            {
                al.Sort();
            }
            catch (Exception exc)
            {
                Console.WriteLine("\n couldnot sort");
            }
            Console.WriteLine("\n after sorting");
            Console.WriteLine("-----------------------------------");
            foreach(string s1 in al)
            {
                Console.WriteLine(s1.ToString());
            }
            Console.WriteLine("\n\nis india in the list?");
            Console.WriteLine("search result: " + al.Contains("india"));

        }
        */

      /*  public void MySortedList()
        {
            //meant for creating name value pair in .net using generics
            //by default it sorts using key
            Console.WriteLine("items in the generic list");
            SortedList<string, string> s1 = new SortedList<string, string>();
            s1.Add("daJap", "Japan");
            s1.Add("daInd", "India");
            s1.Add("cUKD", "United Kingdom");
            s1.Add("bUSA", "United states of america");
            s1.Add("aSng", "Singapore");
            //s1.Add("aSng", "singaaaapore");//duplicate key runtime error
            //s1.Add(23, "Lanka");//compilation error
            Console.WriteLine("key   |value");
            Console.WriteLine("---------------------");
            foreach(KeyValuePair<string,string> de in s1)
            {
                Console.WriteLine("{0}|{1}",de.Key,de.Value);
            }
        }
        */

      /*  public void MyQueue()
        {
            //queue using generics(first in first out)
            Queue<string> mq = new Queue<string>();
            mq.Enqueue("object 1 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            mq.Enqueue("object 2 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            mq.Enqueue("object 3 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            mq.Enqueue("object 4 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            mq.Enqueue("object 5 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);

           // mq.Enqueue(234);//compilation error

           //for navigating alone
           foreach(string s in mq)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n items in the generics queue:{0}",mq.Count);
            //for dequeueing
            Console.WriteLine("\n\n");
            int iTempCount = 6;
            while (mq.Count > 0)
            {
                Console.WriteLine(mq.Dequeue());

                if (iTempCount < 10)
                {
                    Thread.Sleep(15);
                    mq.Enqueue("object" + iTempCount + "arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
                    iTempCount++;
                }
            }

            //queue is empty now
            Console.WriteLine("\nitems in the generics queue:{0}",mq.Count);
        }
        */
      /*  public void MyStack()
        {
            //first in:last out process
            Stack<string> st = new Stack<string>();
            st.Push("object 1 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            st.Push("object 2 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            st.Push("object 3 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            st.Push("object 4 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
            st.Push("object 5 arrived at" + System.DateTime.Now + ":" + System.DateTime.Now.Millisecond);
            Thread.Sleep(10);
           // st.Push(1235);//compilation error

            //for navigation alone
            foreach(string s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n number of items in generics stack:"+st.Count);
            while (st.Count>0)
            {
                Console.WriteLine("{0}",st.Pop());
            }
            Console.WriteLine("\n no of items in generics stack:"+st.Count);
        }
        */

        public void MyListUsingCustomType()
        {
            Console.WriteLine("inside generics system collections list for employee");
            List<MyEmployee> emplist = new List<MyEmployee>();

            MyEmployee eObj1 = new MyEmployee()
            {
                No = 51,
                Name = "isha",
                Age = 28
            };

            emplist.Add(eObj1);

            eObj1 = new MyEmployee()
            {
                No = 53,
                Name = "ani",
                Age = 22
            };

            emplist.Add(eObj1);
            eObj1 = new MyEmployee()
            {
                No = 52,
                Name = "deek",
                Age = 26
            };

            emplist.Add(eObj1);
            eObj1 = new MyEmployee()
            {
                No = 55,
                Name = "adi",
                Age = 27
            };

            emplist.Add(eObj1);
            eObj1 = new MyEmployee()
            {
                No = 54,
                Name = "sannu",
                Age = 23
            };

            emplist.Add(eObj1);

            Console.WriteLine("employee list with out sorting");
            foreach(MyEmployee e in emplist)//possible because IEnumerable is implemented bt list
            {
                e.display();
            }
            try {
                emplist.Sort();//error if employee does not implement IComparable interface
                //emplist.Reverse();//for ascending
                //internally will use compareTo() function
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            Console.WriteLine("employee list after sorting");
            for(int x=0;x<emplist.Count;x++)
            {
                emplist[x].display();//iteration using indexers
             //   emp.get(x).display();//if indexers was not implemented by list
            }
        }
    }
}
