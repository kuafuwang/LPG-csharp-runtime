using System;

namespace LPG2.Runtime
{

    public class NotDeterministicParseTableException : Exception
    {
        /**
     * 
     */
       private string str;

        public NotDeterministicParseTableException()
        {
            str = "NotDeterministicParseTableException";
        }

        public NotDeterministicParseTableException(string str)
        {
            this.str = str;
        }

        public string toString()
        {
            return str;
        }
    }
}