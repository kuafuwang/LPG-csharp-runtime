using System;

namespace LPG2.Runtime
{

    public class UnavailableParserInformationException : Exception
    {
        /**
     * 
     */

        private string str;

        public UnavailableParserInformationException()
        {
            str = "Unavailable parser Information Exception";
        }

        public UnavailableParserInformationException(string str)
        {
            this.str = str;
        }

        public override string ToString()
        {
            return str;
        }
    }
}