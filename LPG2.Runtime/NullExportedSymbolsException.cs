using System;

namespace LPG2.Runtime
{

    public class NullExportedSymbolsException : Exception
    {
        /**
     * 
     */
    
        private string str;

        public NullExportedSymbolsException()
        {
            str = "NullExportedSymbolsException";
        }

        public NullExportedSymbolsException(string str)
        {
            this.str = str;
        }

        public override string ToString()
        {
            return str;
        }
    }
}