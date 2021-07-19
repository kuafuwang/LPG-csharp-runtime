using System;
using System.Collections.Generic;
using System.Text;

namespace LPG2.Runtime
{
 public  static  class Util
    {
        public static void arraycopy<T>(T[] src, int srcPos, T[] dest, int destPos, int length)
        {
            for (int i = 0; i < length; ++i)
            {
                dest[destPos + i] = src[srcPos + i];
            }
        }
    }
}
