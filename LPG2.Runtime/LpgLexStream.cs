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
public  class LpgLexStream : LexStream
{
    /**
     * 
     */
    public LpgLexStream() {
       
    }

    /**
     * @param tab
     */
    public LpgLexStream(int tab):base(tab) {
        
    }

    /**
     * @param fileName
     */
    public LpgLexStream(string fileName) :base(fileName)
    {
    	
    }

    /**
     * @param fileName
     * @param tab
     */
    public LpgLexStream(string fileName, int tab): base(fileName, tab)
    {
    	
    }

    /**
     * @param inputChars
     * @param fileName
     */
    public LpgLexStream(char[] inputChars, string fileName) : base(inputChars, fileName) {
       
    }

    /**
     * @param lineOffsets
     * @param inputChars
     * @param fileName
     */
    public LpgLexStream(IntSegmentedTuple lineOffsets, char[] inputChars, string fileName) :
        base(lineOffsets, inputChars, fileName) {
       
    }

    /**
     * @param inputChars
     * @param fileName
     * @param tab
     */
    public LpgLexStream(char[] inputChars, string fileName, int tab):
        base(inputChars, fileName, tab){
       
    }

    /**
     * @param lineOffsets
     * @param inputChars
     * @param fileName
     * @param tab
     */
    public LpgLexStream(IntSegmentedTuple lineOffsets, char[] inputChars, string fileName, int tab)
   : base(lineOffsets, inputChars, fileName, tab){
        
    }

    /* (non-Javadoc)
     * @see lpg.runtime.TokenStream#getKind(int)
     */
 


}
}