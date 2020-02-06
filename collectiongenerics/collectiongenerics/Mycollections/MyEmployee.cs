using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiongenerics.Mycollections
{
    class MyEmployee:System.IComparable<MyEmployee>
    {
        public int No;
        public string Name;
        public int Age;
        public void display()
        {
            pl(No.ToString());
            pl(Name);
            pl(Age.ToString());
            Console.WriteLine("");

        }

        void pl(string s)
        {
            Console.WriteLine(s+"");
        }

        public int CompareTo(MyEmployee other)
        {
            int iStatus = 0;
            //below code has been done to show ascending sort
            if (this.No < other.No)
                iStatus = 1;//actually -1
            if (this.No == other.No)
                iStatus = 0;
            if (this.No> other.No)
                iStatus = -1;//actually 1

            return iStatus;
        }
    }
}
