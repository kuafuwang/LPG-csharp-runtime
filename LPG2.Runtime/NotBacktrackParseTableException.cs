using System;

namespace LPG2.Runtime
{

    public class NotBacktrackParseTableException : Exception
    {
    /**
     * 
     */
   
    private string str;

    public NotBacktrackParseTableException()
    {
        str = "NotBacktrackParseTableException";
    }

    public NotBacktrackParseTableException(string str)
    {
        this.str = str;
    }

    public override string ToString()
    {
        return str;
    }
    }
}
