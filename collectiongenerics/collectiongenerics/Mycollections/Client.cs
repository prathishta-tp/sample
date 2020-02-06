using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiongenerics.Mycollections
{
    class Client
    {
        static void Main(string[] args)
        {
            // NormalCollections nc = new NormalCollections();
            //nc.myArrayList();
            GenericCollections gc = new GenericCollections();
            //gc.MyList();
            // gc.MySortedList();
            //gc.MyQueue();
            //gc.MyStack();
            gc.MyListUsingCustomType();

        }
    }
}
