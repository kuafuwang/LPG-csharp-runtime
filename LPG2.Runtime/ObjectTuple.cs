using System;

namespace LPG2.Runtime
{


//
// This Tuple class can be used to construct a dynamic
// array of integers. The space for the array is allocated in
// blocks of size 2**LOG_BLKSIZE. In declaring a tuple the user
// may specify an estimate of how many elements he expects.
// Based on that estimate, suitable values will be calculated
// for log_blksize and base_increment. If these estimates are
// found to be off later, more space will be allocated.
//
    public class ObjectTuple
    {
        object[] array;
        int top;

        //
        // This function is used to reset the size of a dynamic array without
        // allocating or deallocting space. It may be invoked with an integer
        // argument n which indicates the new size or with no argument which
        // indicates that the size should be reset to 0.
        //
        public void reset()
        {
            reset(0);
        }

        public void reset(int n)
        {
            top = n;
        }

        //
        // Return size of the dynamic array.
        //
        public int size()
        {
            return top;
        }

        //
        // Return a reference to the ith element of the dynamic array.
        //
        // Note that no check is made here to ensure that 0 <= i < top.
        // Such a check might be useful for debugging and a range exception
        // should be thrown if it yields true.
        //
        public object get(int i)
        {
            return array[i];
        }

        //
        // Insert an element in the dynamic array at the location indicated.
        //
        public void set(int i, object element)
        {
            array[i] = element;
        }

        //
        // Add an element to the dynamic array and return the top index.
        //
        public int nextIndex()
        {
            int i = top++;
            if (i >= array.Length)
            {
                Array.Copy(array, 0, array = new object[i * 2], 0, i);
            }

            return i;
        }

        //
        // Add an element to the dynamic array and return a reference to
        // that new element.
        //
       public void add(object element)
        {
            int i = nextIndex();
            array[i] = element;
        }

        //
        // Constructor of a Tuple
        //
       
      public  ObjectTuple(int estimate=10)
        {
            array = new object[estimate];
        }
    };
}