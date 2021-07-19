using System;

namespace LPG2.Runtime
{

    public class BadParseSymFileException : Exception
    {
    /**
     * 
     */
   
    private string str;

    public BadParseSymFileException()
    {
        str = "BadParseSymFileException";
    }

    public BadParseSymFileException(string str)
    {
        this.str = str;
    }

    public override string ToString()
    {
        return str;
    }
    }
}