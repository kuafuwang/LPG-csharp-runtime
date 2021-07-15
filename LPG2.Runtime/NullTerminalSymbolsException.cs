using System;

namespace LPG2.Runtime
{

    public class NullTerminalSymbolsException : Exception
    {
        /**
     * 
     */
     
        private string str;

        public NullTerminalSymbolsException()
        {
            str = "NullTerminalSymbolsException";
        }

        public NullTerminalSymbolsException(string str)
        {
            this.str = str;
        }

        public string toString()
        {
            return str;
        }
    }
}