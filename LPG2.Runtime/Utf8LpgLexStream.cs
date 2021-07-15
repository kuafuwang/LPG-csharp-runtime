/*
 * Created on Oct 7, 2004
 *
 *  To be used by an lpg generated lexer
*/
namespace LPG2.Runtime
{

/**
 * @author fisher
 *
 */
public abstract class Utf8LpgLexStream : Utf8LexStream
{
    /**
     * 
     */
    public Utf8LpgLexStream() {
        
    }

    /**
     * @param tab
     */
    public Utf8LpgLexStream(int tab):base(tab) {
       
    }

    /**
     * @param fileName
     */
    public Utf8LpgLexStream(string fileName) 	:base(fileName)
    {
    
    }

    /**
     * @param fileName
     * @param tab
     */
    public Utf8LpgLexStream(string fileName, int tab) :base(fileName, tab)
    {
    	
    }

    /**
     * @param inputChars
     * @param fileName
     */
    public Utf8LpgLexStream(byte[] inputChars, string fileName): base(inputChars, fileName)
    {
       
    }

    /**
     * @param lineOffsets
     * @param inputChars
     * @param fileName
     */
    public Utf8LpgLexStream(IntSegmentedTuple lineOffsets, byte[] inputChars, string fileName)
        :base(lineOffsets, inputChars, fileName)
    {
        
    }

    /**
     * @param inputChars
     * @param fileName
     * @param tab
     */
    public Utf8LpgLexStream(byte[] inputChars, string fileName, int tab):
        base(inputChars, fileName, tab){
       
    }

    /**
     * @param lineOffsets
     * @param inputChars
     * @param fileName
     * @param tab
     */
    public Utf8LpgLexStream(IntSegmentedTuple lineOffsets, byte[] inputChars, string fileName, int tab)
    :base(lineOffsets, inputChars, fileName, tab){
        
    }

    /* (non-Javadoc)
     * @see lpg.runtime.TokenStream#getKind(int)
     */

}
}