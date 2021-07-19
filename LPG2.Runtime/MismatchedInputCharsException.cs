using System;

namespace LPG2.Runtime
{

    public class MismatchedInputCharsException : SystemException
    {
        /**
     * 
     */
     
        private string str;

        public MismatchedInputCharsException()
        {
            str = "MismatchedInputCharsException";
        }

        public MismatchedInputCharsException(string str)
        {
            this.str = str;
        }

        public override string ToString()
        {
            return str;
        }
    }
}