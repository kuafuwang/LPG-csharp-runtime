using System;

namespace LPG2.Runtime
{

    public class TokenStreamNotIPrsStreamException : Exception
    {
    /**
     * 
     */


    private string str;

    public TokenStreamNotIPrsStreamException()
    {
        str = "TokenStreamNotIPrsStreamException";
    }

    public TokenStreamNotIPrsStreamException(string str)
    {
        this.str = str;
    }

    public string toString()
    {
        return str;
    }
    }
}