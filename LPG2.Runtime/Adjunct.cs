namespace LPG2.Runtime
{

    public class Adjunct : AbstractToken
    {
        public Adjunct()
        {
        }

        public Adjunct(IPrsStream prsStream, int startOffset, int endOffset, int kind)
            : base(prsStream, startOffset, endOffset, kind)
        {
            
        }

        public override IToken[] getFollowingAdjuncts()
        {
            return null;
        }

        public override IToken[] getPrecedingAdjuncts()  
        {
            return null;
        }
    }
}
