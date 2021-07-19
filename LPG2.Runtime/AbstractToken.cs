namespace LPG2.Runtime
{

    public   abstract class AbstractToken : IToken
    {
        private int kind = 0,
            startOffset = 0,
            endOffset = 0,
            tokenIndex = 0,
            adjunctIndex;

        private IPrsStream iPrsStream;

        public   AbstractToken()
        {
        }

        public   AbstractToken(IPrsStream iPrsStream, int startOffset, int endOffset, int kind)
        {
            this.iPrsStream = iPrsStream;
            this.startOffset = startOffset;
            this.endOffset = endOffset;
            this.kind = kind;
        }

        public   virtual int getKind()
        {
            return kind;
        }

        public virtual  void setKind(int kind)
        {
            this.kind = kind;
        }

        public virtual  int getStartOffset()
        {
            return startOffset;
        }

        public virtual  void setStartOffset(int startOffset)
        {
            this.startOffset = startOffset;
        }

        public virtual  int getEndOffset()
        {
            return endOffset;
        }

        public virtual  void setEndOffset(int endOffset)
        {
            this.endOffset = endOffset;
        }

        public virtual  int getTokenIndex()
        {
            return tokenIndex;
        }

        public virtual  void setTokenIndex(int tokenIndex)
        {
            this.tokenIndex = tokenIndex;
        }

        public virtual  void setAdjunctIndex(int adjunctIndex)
        {
            this.adjunctIndex = adjunctIndex;
        }

        public   abstract IToken[] getPrecedingAdjuncts();
        public   abstract IToken[] getFollowingAdjuncts();

        public virtual  int getAdjunctIndex()
        {
            return adjunctIndex;
        }

        public virtual  IPrsStream getIPrsStream()
        {
            return iPrsStream;
        }

        public virtual  ILexStream getILexStream()
        {
            return iPrsStream == null ? null : iPrsStream.getILexStream();
        }

        public virtual  int getLine()
        {
            return (iPrsStream == null ? 0 : iPrsStream.getILexStream().getLineNumberOfCharAt(startOffset));
        }

        public virtual  int getColumn()
        {
            return (iPrsStream == null ? 0 : iPrsStream.getILexStream().getColumnOfCharAt(startOffset));
        }

        public virtual  int getEndLine()
        {
            return (iPrsStream == null ? 0 : iPrsStream.getILexStream().getLineNumberOfCharAt(endOffset));
        }

        public virtual  int getEndColumn()
        {
            return (iPrsStream == null ? 0 : iPrsStream.getILexStream().getColumnOfCharAt(endOffset));
        }

        /**
     * @deprecated replaced by {@link #getIPrsStream()}
     */
        public virtual  IPrsStream getPrsStream()
        {
            return iPrsStream;
        }


        /**
     * @deprecated replaced by {@link #getILexStream()}
     */
        public virtual  ILexStream getLexStream()
        {
            return iPrsStream == null ? null : iPrsStream.getILexStream();
        }

        /**
     * @deprecated replaced by {@link #ToString()}
     */
        public virtual  string getValue(char[] inputChars)
        {
            if (iPrsStream != null)
                return ToString();
            if (iPrsStream.getLexStream() is LexStream)
            {
                LexStream lex_stream = (LexStream) iPrsStream.getLexStream();
                if (inputChars != lex_stream.getInputChars())
                    throw new MismatchedInputCharsException();
                return ToString();
            }
            throw new UnknownStreamType("Unknown stream type " +
                                        iPrsStream.getLexStream().GetType().ToString());
        }

        public override  string ToString()
        {
            return (iPrsStream == null
                ? "<ToString>"
                : iPrsStream.ToString(this, this));
        }
    }
}