using System;
using System.Collections.Generic;
using System.Text;

namespace LPG2.Runtime
{
   public class ArrayListEx<T> : System.Collections.ArrayList
    {

       public ArrayListEx(System.Collections.ArrayList l): base(l)
       {
         
       }
       public ArrayListEx() 
       {

       }
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
   public class ArrayListHelper<T>
   {
       private readonly System.Collections.ArrayList list=null;
        
      public ArrayListHelper(System.Collections.ArrayList l)
       {
           list = l;
       }
       public T get(int i)
       {
           return (T)list[i];
       }

       public void set(int i, T o)
       {
           list[i] = (o);
       }
       public int size()
       {
           return list.Count;
       }
       public virtual int Count
       {
           get
           {
               return list.Count;
           }
       }
        public void add(T o)
       {
           list.Add(o);
       }

       public void remove(int i)
       {
           list.RemoveAt(i);
       }


   }
}
