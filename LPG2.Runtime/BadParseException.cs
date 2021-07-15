using System;

namespace LPG2.Runtime
{

    public class BadParseException : Exception
    {
        /**
     * 
     */
        public int error_token;

        public BadParseException(int error_token)
        {
            this.error_token = error_token;
        }
    }
}