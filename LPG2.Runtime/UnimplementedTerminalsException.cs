using System;
using System.Collections;

namespace LPG2.Runtime
{


    public class UnimplementedTerminalsException : Exception
    {
        /**
     * 
     */


        ArrayList symbols;

        public UnimplementedTerminalsException(ArrayList symbols)
        {
            this.symbols = symbols;
        }

        public ArrayList getSymbols()
        {
            return symbols;
        }
    }
}