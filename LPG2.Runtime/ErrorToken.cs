namespace LPG2.Runtime
{

    public class ErrorToken : Token
    {
        private IToken firstToken,
            lastToken,
            errorToken;

        public ErrorToken(IToken firstToken, IToken lastToken, IToken errorToken, int startOffset, int endOffset,
            int kind): base(firstToken.getIPrsStream(), startOffset, endOffset, kind)
        {
            

            this.firstToken = firstToken;
            this.lastToken = lastToken;
            this.errorToken = errorToken;
        }

        /**
     * @deprecated replaced by {@link #getFirstRealToken()}
     *
     */
        public IToken getFirstToken()
        {
            return getFirstRealToken();
        }

        public IToken getFirstRealToken()
        {
            return firstToken;
        }

        /**
     * @deprecated replaced by {@link #getLastRealToken()}
     *
     */
        public IToken getLastToken()
        {
            return getLastRealToken();
        }

        public IToken getLastRealToken()
        {
            return lastToken;
        }

        public IToken getErrorToken()
        {
            return errorToken;
        }

        public override IToken[] getPrecedingAdjuncts()
        {
            return firstToken.getPrecedingAdjuncts();
        }

        public override IToken[] getFollowingAdjuncts()
        {
            return lastToken.getFollowingAdjuncts();
        }
    }

}