using System;
using System.Collections.Generic;
using System.Text;

namespace LPG2.Runtime
{
   public class ArrayList<T> : System.Collections.ArrayList
    {
        
       public T get(int i)
       {
           return (T)base[i];
       }
       
       public void set(int i,T o)
       {
           base[i]=(o);
       }
        public int size()
       {
           return base.Count;
       }

       public void add(T o)
       {
           base.Add(o);
       }

       public void remove(int i)
       {
           base.RemoveAt(i);
       }

 
    }
}
