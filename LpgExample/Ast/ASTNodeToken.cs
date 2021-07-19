namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
public   class ASTNodeToken : ASTNode , IASTNodeToken
{
    public ASTNodeToken(IToken token) :base(token){  }
    public IToken getIToken() { return leftIToken; }
    public override string ToString() { return leftIToken.ToString(); }

    /**
     * A token class has no children. So, we return the empty list.
     */
    public override System.Collections.ArrayList getAllChildren() { return new System.Collections.ArrayList(); }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is ASTNodeToken)) return false;
        ASTNodeToken other = (ASTNodeToken) o;
        return getIToken().getILexStream() == other.getIToken().getILexStream() &&
               getIToken().getTokenIndex() == other.getIToken().getTokenIndex();
    }

    public override int GetHashCode()
    {
        int hash = 7;
        if (getIToken().getILexStream() != null) hash = hash * 31 + getIToken().getILexStream().GetHashCode();
        hash = hash * 31 + getIToken().getTokenIndex();
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}

}

