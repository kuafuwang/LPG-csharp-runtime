using System;
using System.Collections.Generic;
using System.Text;

namespace LPG2.Runtime
{
   public class ArrayList : System.Collections.ArrayList
    {
        public object get(int i)
        {
            return base[i];
        }

        public int size()
        {
            return base.Count;
        }

        public void add(object o)
        {
            base.Add(o);
        }

        public void remove(int i)
        {
            base.RemoveAt(i);
        }
    }
}
