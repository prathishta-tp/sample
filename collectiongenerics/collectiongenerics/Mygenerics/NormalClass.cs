﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectiongenerics.Mygenerics
{
    class NormalClass
    {
        public void interchange(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
