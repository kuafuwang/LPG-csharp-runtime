namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 44:  aliasSpec ::= SYMBOL produces alias_rhs
 *</b>
 */
public class aliasSpec4 : ASTNode , IaliasSpec
{
    private ASTNodeToken _SYMBOL;
    private Iproduces _produces;
    private Ialias_rhs _alias_rhs;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public Ialias_rhs getalias_rhs() { return _alias_rhs; }
    public void setalias_rhs(Ialias_rhs _alias_rhs) { this._alias_rhs = _alias_rhs; }

    public aliasSpec4(IToken leftIToken, IToken rightIToken,
                      ASTNodeToken _SYMBOL,
                      Iproduces _produces,
                      Ialias_rhs _alias_rhs)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._produces = _produces;
        ((ASTNode) _produces).setParent(this);
        this._alias_rhs = _alias_rhs;
        ((ASTNode) _alias_rhs).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        list.Add(_produces);
        list.Add(_alias_rhs);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is aliasSpec4)) return false;
        if (! base.Equals(o)) return false;
        aliasSpec4 other = (aliasSpec4) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _alias_rhs.Equals(other._alias_rhs)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_produces.GetHashCode());
        hash = hash * 31 + (_alias_rhs.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


