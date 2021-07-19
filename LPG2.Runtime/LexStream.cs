using System;
using System.IO;
using LPG2.Runtime;

namespace LPG2.Runtime
{


//
// LexStream contains an array of characters as the input stream to be parsed.
// There are methods to retrieve and classify characters.
// The lexparser "token" is implemented simply as the index of the next character in the array.
// The user must subclass LexStreamBase and implement the abstract methods: getKind.
//
public  class LexStream : ParseErrorCodes, ILexStream
{
    const  int DEFAULT_TAB = 1;

    private int index = -1;
    private int streamLength = 0;
    private char[] inputChars;
    private string fileName;
    private IntSegmentedTuple lineOffsets;
    private int tab = DEFAULT_TAB;

    /**
     * @deprecated Use function getIPrsStream()
     */
    protected /* private ... when not deprecated! */ IPrsStream prsStream;

    public LexStream() // can be used with explicit initialize call
    {
        lineOffsets = new IntSegmentedTuple(12); 
        setLineOffset(-1);
    }

    public LexStream(int tab):this() {  this.tab = tab; } // can be used with explicit initialize call

    public LexStream(string fileName)  :this(fileName, DEFAULT_TAB)
    {
       
    }

    public LexStream(string fileName, int tab) :  this(tab)
    {
      
        initialize(fileName);
    }

    public LexStream(char[] inputChars, string fileName) :this()
    {
       
        initialize(inputChars, fileName);
    }

    public LexStream(IntSegmentedTuple lineOffsets, char[] inputChars, string fileName)
    {
        initialize(lineOffsets, inputChars, fileName);
    }

    public LexStream(char[] inputChars, string fileName, int tab) : this(tab)
    {
      
        initialize(inputChars, fileName);
    }

    public LexStream(IntSegmentedTuple lineOffsets, char[] inputChars, string fileName, int tab)
    {
        this.tab = tab;
        initialize(lineOffsets, inputChars, fileName);
    }

    public void initialize(string fileName) 
    {
        try
        {
            string text = System.IO.File.ReadAllText(fileName);
            initialize(text.ToCharArray(), fileName);
        }
        catch (Exception e)
        {
            IOException io = new IOException();

            Console.Error.WriteLine(e.Message);
          
            throw(io);
        }
    }
    
    public void initialize(char[] inputChars, string fileName)
    {
        setInputChars(inputChars);
        setStreamLength(inputChars.Length);
        setFileName(fileName);
        computeLineOffsets();        
    }

    public void initialize(IntSegmentedTuple lineOffsets, char[] inputChars, string fileName)
    {
        this.lineOffsets = lineOffsets;
        setInputChars(inputChars);
        setStreamLength(inputChars.Length);
        setFileName(fileName);
    }

    public void computeLineOffsets()
    {
        lineOffsets.reset();
        setLineOffset(-1);
        for (int i = 0; i < inputChars.Length; i++)
            if (inputChars[i] == 0x0A) setLineOffset(i);
    }

    public void setInputChars(char[] inputChars)
    {
        this.inputChars = inputChars;
        index = -1; // reset the start index to the beginning of the input
    }

    public char[] getInputChars() { return inputChars; }

    public void setFileName(string fileName) { this.fileName = fileName; }

    public  virtual   string getFileName() { return fileName; }

    public void setLineOffsets(IntSegmentedTuple lineOffsets) { this.lineOffsets = lineOffsets; }

    public IntSegmentedTuple getLineOffsets() { return lineOffsets; }

    public void setTab(int tab) { this.tab = tab; }

    public int getTab() { return tab; }
    
    public void setStreamIndex(int index) { this.index = index; }

    public int getStreamIndex() { return index; }

    public void setStreamLength(int streamLength) { this.streamLength = streamLength; }

    public virtual  int getStreamLength() { return streamLength; }

    public void setLineOffset(int i)
    {
        lineOffsets.add(i);
    }

    public virtual  int getLineOffset(int i) { return lineOffsets.get(i); }

    public virtual  void setPrsStream(IPrsStream prsStream)
    {
        prsStream.setLexStream(this);
        this.prsStream = prsStream;
    }

    public virtual  IPrsStream getIPrsStream()
    {
        return prsStream;
    }
    
    /**
     * @deprecated replaced by {@link #getIPrsStream()}
     */
    public virtual  IPrsStream getPrsStream()
    {
        return prsStream;
    }

    public virtual  string[] orderedExportedSymbols()
    {
        return null;
    }

    public virtual  char getCharValue(int i) { return inputChars[i]; }

    public virtual  int getIntValue(int i) { return inputChars[i]; }

    /**
     * @deprecated replaced by {@link #getLineCount()}
     *
     */
    public int getLine() { return getLineCount(); }
    public virtual  int getLineCount() { return lineOffsets.size() - 1; }

    public virtual  int getLineNumberOfCharAt(int i)
    {
        int index = lineOffsets.binarySearch(i);
        return index < 0 ? -index : index == 0 ? 1 : index;
    }

    public virtual   int getColumnOfCharAt(int i)
    {
        int lineNo = getLineNumberOfCharAt(i),
            start = lineOffsets.get(lineNo - 1);
        if (start + 1 >= streamLength) return 1;        
        for (int k = start + 1; k < i; k++)
        {
            if (inputChars[k] == '\t')
            {
                int offset = (k - start) - 1;
                start -= ((tab - 1) - offset % tab);
            }
        }
        return i - start;
    }

    //
    // Methods that implement the TokenStream Interface.
    // Note that this function updates the lineOffsets table
    // as a side-effect when the next character is a line feed.
    // If this is not the expected behavior then this function should 
    // be overridden.
    //
    public virtual  int getToken() { return index = getNext(index); }

    public virtual  int getToken(int end_token)
         { return index = (index < end_token ? getNext(index) : streamLength); }

    public virtual int getKind(int i) { return 0; }


/**
         * @deprecated replaced by {@link #getNext()}
         *
         */
        int next(int i) { return getNext(i); }
    public virtual  int getNext(int i) { return (++i < streamLength ? i : streamLength); }

        /**
         * @deprecated replaced by {@link #getPrevious()}
         *
         */ 
        public  int previous(int i) { return getPrevious(i); }
    public virtual  int getPrevious(int i) { return (i <= 0 ? 0 : i - 1); }

    public virtual  string getName(int i) { return i >= getStreamLength() ? "" : "" + getCharValue(i); }

    public virtual  int peek() { return getNext(index); }

    public virtual  void reset(int i) { index = i - 1; }

    public virtual  void reset() { index = -1; }

    public virtual  int badToken() { return 0; }

    public virtual  int getLine(int i) { return getLineNumberOfCharAt(i); }

    public virtual  int getColumn(int i) { return getColumnOfCharAt(i); }

    public virtual  int getEndLine(int i) { return getLine(i); }

    public virtual  int getEndColumn(int i) { return getColumnOfCharAt(i); }

    public virtual  bool afterEol(int i)
    {
        return (i < 1 ? true : getLineNumberOfCharAt(i - 1) < getLineNumberOfCharAt(i));
    }

    /**
     * @deprecated replaced by {@link #getFirstRealToken()}
     *
     */
    public virtual int getFirstErrorToken(int i) { return getFirstRealToken(i); }
    public virtual   int getFirstRealToken(int i) { return i; }

    /**
     * @deprecated replaced by {@link #getLastRealToken()}
     *
     */
    public virtual int getLastErrorToken(int i) { return getLastRealToken(i); }
    public virtual  int getLastRealToken(int i) { return i; }

    //
    // Here is where we report errors.  The default method is simply to print the error message to the console.
    // However, the user may supply an error message handler to process error messages.  To support that
    // a message handler interface is provided that has a single method handleMessage().  The user has his
    // error message handler class implement the IMessageHandler interface and provides an object of this type
    // to the runtime using the setMessageHandler(errorMsg) method. If the message handler object is set, 
    // the reportError methods will invoke its handleMessage() method.
    //
    private IMessageHandler errMsg = null;// this is the error message handler object
    
    public virtual  void setMessageHandler(IMessageHandler errMsg) { this.errMsg = errMsg; }

    public virtual  IMessageHandler getMessageHandler() { return errMsg; }
    
    public virtual  void makeToken(int startLoc, int endLoc, int kind)
    {
        if (prsStream != null) // let the parser find the error
             prsStream.makeToken(startLoc, endLoc, kind);
        else this.reportLexicalError(startLoc, endLoc); // make it a lexical error
    }

    public virtual  void  reportLexicalError(int left_loc, int right_loc)
    {
        int errorCode = (right_loc >= streamLength
                                    ? EOF_CODE
                                    : left_loc == right_loc
                                                ? LEX_ERROR_CODE
                                                : INVALID_TOKEN_CODE);
        string tokenText = (errorCode == EOF_CODE
                                       ? "End-of-file "
                                       : errorCode == INVALID_TOKEN_CODE
                                                    ? "\"" + new string(inputChars, left_loc, right_loc - left_loc + 1) + "\" "
                                                    : "\"" + getCharValue(left_loc) + "\" ");
        reportLexicalError(errorCode, left_loc, right_loc, 0, 0, new string[] { tokenText });
    }

    /**
     * See IMessaageHandler for a description of the int[] return value.
     */
    public virtual  int[] getLocation(int left_loc, int right_loc)
    {
        int length = (right_loc < streamLength
                                ? right_loc
                                : streamLength - 1) - left_loc + 1;
        return new int[]
               { 
                   left_loc,
                   length,
                   getLineNumberOfCharAt(left_loc),
                   getColumnOfCharAt(left_loc),
                   getLineNumberOfCharAt(right_loc),
                   getColumnOfCharAt(right_loc)
               };
    }
    
    public virtual  void reportLexicalError(int errorCode, int left_loc, int right_loc, int error_left_loc, int error_right_loc,
        string[] errorInfo)
    {
        if (errMsg == null)
        {
            string locationInfo = getFileName() + ':' + getLineNumberOfCharAt(left_loc) + ':'
                                                      + getColumnOfCharAt(left_loc) + ':'
                                                      + getLineNumberOfCharAt(right_loc) + ':'
                                                      + getColumnOfCharAt(right_loc) + ':'
                                                      + error_left_loc + ':'
                                                      + error_right_loc + ':'
                                                      + errorCode + ": ";
           Console.Out.Write("****Error: " + locationInfo);
            if (errorInfo != null)
            {
                for (int i = 0; i < errorInfo.Length; i++)
                   Console.Out.Write(errorInfo[i] + " ");
            }
            Console.Out.WriteLine(errorMsgText[errorCode]);
        }
        else
        {
            /**
             * This is the only method in the IMessageHandler interface
             * It is called with the following arguments:
             */
            errMsg.handleMessage(errorCode,
                                 getLocation(left_loc, right_loc),
                                 getLocation(error_left_loc, error_right_loc),
                                 getFileName(),
                                 errorInfo);
        }
    }

    //
    // Note that when this function is invoked, the leftToken and rightToken are assumed
    // to be indexes into the input stream as the tokens for a lexer are the characters
    // in the input stream.
    //
    public virtual  void reportError(int errorCode, int leftToken, int rightToken, string errorInfo)
    {
        reportError(errorCode, 
                    leftToken, 
                    0,
                    rightToken,
                    errorInfo == null ? null : new string[] { errorInfo });
    }
    
    public virtual  void reportError(int errorCode, int leftToken, int rightToken, string []errorInfo)
    {
        reportError(errorCode, 
                    leftToken, 
                    0,
                    rightToken,
                    errorInfo);
    }

    //
    // Note that when this function is invoked, the leftToken and rightToken are assumed
    // to be indexes into the input stream as the tokens for a lexer are the characters
    // in the input stream.
    //
    public virtual  void reportError(int errorCode, int leftToken, int errorToken, int rightToken, string errorInfo)
    {
        reportError(errorCode, 
                    leftToken, 
                    errorToken,
                    rightToken,
                    errorInfo == null ? null : new string[] { errorInfo });
    }
    
    public virtual  void reportError(int errorCode, int leftToken, int errorToken, int rightToken, string[] errorInfo)
    {
        reportLexicalError(errorCode, 
                           leftToken, 
                           rightToken,
                           errorToken,
                           errorToken,
                           errorInfo == null ? new string[] {} : errorInfo);
    }
    
    public virtual  string ToString(int startOffset, int endOffset)
    {
        int length = endOffset - startOffset + 1;
        return (endOffset >= inputChars.Length
                    ? "$EOF"
                    : length <= 0
                        ? ""
                        : new string(inputChars, startOffset, length));
    }
}
}