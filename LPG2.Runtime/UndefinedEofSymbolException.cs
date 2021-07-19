using System;

namespace LPG2.Runtime
{

    public class UndefinedEofSymbolException : Exception
    {
        /**
     * 
     */

        private string str;

        public UndefinedEofSymbolException()
        {
            str = "UndefinedEofSymbolException";
        }

        public UndefinedEofSymbolException(string str)
        {
            this.str = str;
        }

        public override string ToString()
        {
            return str;
        }
    }
}