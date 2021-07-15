namespace LPG2.Runtime
{

    public class Token : AbstractToken
    {
        public Token()
        {
        }

        public Token(int startOffset, int endOffset, int kind)
            : base(null, startOffset, endOffset, kind)
        {
           
        }

        public Token(IPrsStream iPrsStream, int startOffset, int endOffset, int kind):
            base(iPrsStream, startOffset, endOffset, kind)
        {
           
        }

        //
        // Return an iterator for the adjuncts that follow token i.
        //
        public override IToken[] getFollowingAdjuncts()
        {
            return getIPrsStream().getFollowingAdjuncts(getTokenIndex());
        }

        public override IToken[] getPrecedingAdjuncts()
        {
            return getIPrsStream().getPrecedingAdjuncts(getTokenIndex());
        }

    }
}