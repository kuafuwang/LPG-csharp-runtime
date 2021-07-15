using System.Collections;
using System.Collections.Generic;

namespace LPG2.Runtime
{
    public interface IAst
    {
        public IAst getNextAst();
        public IAst getParent();
        public IToken getLeftIToken();
        public IToken getRightIToken();
        public IToken[] getPrecedingAdjuncts();
        public IToken[] getFollowingAdjuncts();
        public ArrayList getChildren();
        public ArrayList getAllChildren();
        public void accept(IAstVisitor v);
    }

    
}