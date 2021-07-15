using System;

namespace LPG2.Runtime
{

    public class UnknownStreamType : Exception
    {
        /**
     * 
     */
    
        private string str;

        public UnknownStreamType()
        {
            str = "UnknownStreamType";
        }

        public UnknownStreamType(string str)
        {
            this.str = str;
        }

        public string toString()
        {
            return str;
        }
    }
}