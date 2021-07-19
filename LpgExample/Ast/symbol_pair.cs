namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 140:  symbol_pair ::= SYMBOL SYMBOL
 *</b>
 */
public class symbol_pair : ASTNode , Isymbol_pair
{
    private ASTNodeToken _SYMBOL;
    private ASTNodeToken _SYMBOL2;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    public ASTNodeToken getSYMBOL2() { return _SYMBOL2; }
    public void setSYMBOL2(ASTNodeToken _SYMBOL2) { this._SYMBOL2 = _SYMBOL2; }

    public symbol_pair(IToken leftIToken, IToken rightIToken,
                       ASTNodeToken _SYMBOL,
                       ASTNodeToken _SYMBOL2)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._SYMBOL2 = _SYMBOL2;
        ((ASTNode) _SYMBOL2).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        list.Add(_SYMBOL2);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is symbol_pair)) return false;
        if (! base.Equals(o)) return false;
        symbol_pair other = (symbol_pair) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (! _SYMBOL2.Equals(other._SYMBOL2)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_SYMBOL2.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


