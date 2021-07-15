using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LPG2.Runtime
{


//
// This Tuple class can be used to construct a dynamic
// array of objects. The space for the array is allocated in
// blocks of size 2**LOG_BLKSIZE. In declaring a tuple the user
// may specify an estimate of how many elements he expects.
// Based on that estimate, suitable values will be calculated
// for log_blksize and base_increment. If these estimates are
// found to be off later, more space will be allocated.
//
    public class SegmentedTuple<T> : List<T>
    {
        private int modCount = 0;

        private int top,
            size;

        private int log_blksize = 10,
            base_size = 16;

        private object[][] base_buf;

        //
        // Allocate another block of storage for the dynamic array.
        //
        private void allocateMoreSpace()
        {
            //
            // The variable size always indicates the maximum number of
            // elements that has been allocated for the array.
            // Initially, it is set to 0 to indicate that the array is empty.
            // The pool of available elements is divided into segments of size
            // 2**log_blksize each. Each segment is pointed to by a slot in
            // the array base.
            //
            // By dividing size by the size of the segment we obtain the
            // index for the next segment in base. If base is full, it is
            // reallocated.
            //
            //
            int k = size >> log_blksize; /* which segment? */

            //
            // If the base is overflowed, reallocate it and initialize the new
            // elements to NULL.
            // Otherwise, allocate a new segment and place its adjusted address
            // in base[k]. The adjustment allows us to index the segment directly,
            // instead of having to perform a subtraction for each reference.
            // See operator[] below.
            //
            //
            if (k == base_size)
            {
                base_size *= 2;
              
                Array.Copy(base_buf, 0, new object[base_size][], 0, k);
            }

            base_buf[k] = (object[]) new object[1 << log_blksize];

            //
            // Finally, we update SIZE.
            //
            size += (1 << log_blksize);

            return;
        }

        //
        // This function is invoked with an integer argument n. It ensures
        // that enough space is allocated for n elements in the dynamic array.
        // I.e., that the array will be indexable in the range  (0..n-1)
        //
        // Note that this function can be used as a garbage collector.  When
        // invoked with no argument(or 0), it frees up all dynamic space that
        // was allocated for the array.
        //
        public void resize()
        {
            resize(0);
        }

        public void resize(int n)
        {
            modCount++; // tuple structure  modified!
            //
            // If array did not previously contain enough space, allocate
            // the necessary additional space. Otherwise, if the array had
            // more blocks than are needed, release the extra blocks.
            //
            if (n > size)
            {
                do
                {
                    allocateMoreSpace();
                } while (n > size);
            }

            top = n;
        }

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
        public int size2()
        {
            return top;
        }

        //
        // Can the tuple be indexed with i?
        //
        public bool outOfRange(int i)
        {
            return (i < 0 || i >= top);
        }

        //
        // Return a reference to the ith element of the dynamic array.
        //
        // Note that no check is made here to ensure that 0 <= i < top.
        // Such a check might be useful for debugging and a range exception
        // should be thrown if it yields true.
        //
        public T get(int i)
        {
            return (T)base_buf[i >> log_blksize][i % (1 << log_blksize)];
        }

        //
        // Insert an element in the dynamic array at the location indicated.
        //
        public T set(int i, T element)
        {
            object old_value = base_buf[i >> log_blksize][i % (1 << log_blksize)] = element;
            base_buf[i >> log_blksize][i % (1 << log_blksize)] = element;
            return (T)old_value;
        }

        //
        // Add an element to the dynamic array and return the top index.
        //
        public int NextIndex()
        {
            int i = top++;
            if (i == size)
                allocateMoreSpace();
            return i;
        }

        //
        // Add an element to the dynamic array and return a reference to
        // that new element.
        //
        public bool add(T element)
        {
            modCount++; // tuple structure  modified!
            int i = NextIndex();
            base_buf[i >> log_blksize][i % (1 << log_blksize)] = element;

            return true;
        }

        //
        // Default constructor of a Tuple
        //
        public SegmentedTuple()
        {
            this.base_buf = new object[this.base_size][];
        }

        //
        // Constructor of a Tuple
        //
        public SegmentedTuple(int log_blksize_)
        {
            this.log_blksize = log_blksize_;
            this.base_buf = new object[this.base_size][];
        }

        //
        // Constructor of a Tuple
        //
        public SegmentedTuple(int log_blksize_, int base_size_)
        {
            this.log_blksize = log_blksize_;
            this.base_size = (base_size_ <= 0 ? 4 : base_size_);
            this.base_buf = new object[this.base_size][];
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public bool contains(object o)
        {
            for (int i = 0; i < top; i++)
            {
                if (base_buf[i >> log_blksize][i % (1 << log_blksize)] == o)
                    return true;
            }

            return false;
        }

        public object[] toArray()
        {
            object[] result = new object[top];
            for (int i = 0; i < top; i++)
                result[i] = base_buf[i >> log_blksize][i % (1 << log_blksize)];
            return result;
        }

        public <T> T[] toArray(T[] a)
        {
            if (a.Length < top)
                a = (T[]) java.lang.reflect.Array.newInstance(a.getClass().getComponentType(), top);
            for (int i = 0; i < top; i++)
                a[i] = (T)base_buf[i >> log_blksize][i % (1 << log_blksize)];
            if (a.Length > top)
                a[top] = null;
            return a;
        }

        public bool remove(object o)
        {
            throw new UnsupportedOperationException();
        }

        public bool containsAll(Collection<?> c)
        {
            throw new UnsupportedOperationException();
        }

        public bool addAll(Collection<? extends T> c) {
            throw new UnsupportedOperationException();
        }

        public bool addAll(int index, Collection<? extends T> c) {
            throw new UnsupportedOperationException();
        }

        public bool removeAll(Collection<?> c)
        {
            throw new UnsupportedOperationException();
        }

        public bool retainAll(Collection<?> c)
        {
            throw new UnsupportedOperationException();
        }

        public void clear()
        {
            resize();
        }

        public void add(int index, T element)
        {
            throw new UnsupportedOperationException();
        }

        public T remove(int index)
        {
            throw new UnsupportedOperationException();
        }

        public int indexOf(object o)
        {
            for (int i = 0; i < top; i++)
                if (base_buf[i >> log_blksize][i % (1 << log_blksize)] == o)
                    return i;
            return -1;
        }

        public int lastIndexOf(object o)
        {
            for (int i = top - 1; i >= 0; i--)
                if (base_buf[i >> log_blksize][i % (1 << log_blksize)] == o)
                    return i;
            return -1;
        }

        public Iterator<T> iterator()
        {
            return new Itr();
        }

        public ListIterator<T> listIterator()
        {
            return listIterator(0);
        }

        public ListIterator<T> listIterator(int index)
        {
            if (index < 0 || index > size())
                throw new IndexOutOfRangeException("Index: " + index);
            return new ListItr(index);
        }

        public List<T> subList(int fromIndex, int toIndex)
        {
            throw new UnsupportedOperationException();
        }

        /**
     * This is a duplication of the private class by the same name in java.util.AbstractList.
     */
        private class Itr

        : Iterator<T> {
            int cursor = 0;

            int lastRet = -1;

            int expectedModCount = modCount;

            public bool hasNext()
            {
                return cursor != size();
            }

            public T next()
            {
                checkForComodification();
                try
                {
                    T next = get(cursor);
                    lastRet = cursor++;
                    return next;
                }
                catch (IndexOutOfRangeException e)
                {
                    checkForComodification();
                    throw new NoSuchElementException();
                }
            }

            public void remove()
            {
                throw new UnsupportedOperationException();
            }

            const void checkForComodification() {
                if (modCount != expectedModCount)
                    throw new ConcurrentModificationException();
            }
        }

        /**
     * This is a duplication of the private class by the same name in java.util.AbstractList.
     */
        private class ListItr

        extends Itr implements ListIterator<T> {
            ListItr(int index) {
                cursor = index;
            }

            public bool hasPrevious()
            {
                return cursor != 0;
            }

            public T previous()
            {
                checkForComodification();
                try
                {
                    int i = cursor - 1;
                    T previous = get(i);
                    lastRet = cursor = i;
                    return previous;
                }
                catch (IndexOutOfRangeException e)
                {
                    checkForComodification();
                    throw new NoSuchElementException();
                }
            }

            public int nextIndex()
            {
                return cursor;
            }

            public int previousIndex()
            {
                return cursor - 1;
            }

            public void set(T o)
            {
                throw new UnsupportedOperationException();
            }

            public void add(T o)
            {
                throw new UnsupportedOperationException();
            }
        }
    };
}