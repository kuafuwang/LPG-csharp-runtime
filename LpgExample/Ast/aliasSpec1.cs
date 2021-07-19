namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 41:  aliasSpec ::= EOL_KEY produces alias_rhs
 *</b>
 */
public class aliasSpec1 : ASTNode , IaliasSpec
{
    private ASTNodeToken _EOL_KEY;
    private Iproduces _produces;
    private Ialias_rhs _alias_rhs;

    public ASTNodeToken getEOL_KEY() { return _EOL_KEY; }
    public void setEOL_KEY(ASTNodeToken _EOL_KEY) { this._EOL_KEY = _EOL_KEY; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public Ialias_rhs getalias_rhs() { return _alias_rhs; }
    public void setalias_rhs(Ialias_rhs _alias_rhs) { this._alias_rhs = _alias_rhs; }

    public aliasSpec1(IToken leftIToken, IToken rightIToken,
                      ASTNodeToken _EOL_KEY,
                      Iproduces _produces,
                      Ialias_rhs _alias_rhs)
        :base(leftIToken, rightIToken)

    {
        this._EOL_KEY = _EOL_KEY;
        ((ASTNode) _EOL_KEY).setParent(this);
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
        list.Add(_EOL_KEY);
        list.Add(_produces);
        list.Add(_alias_rhs);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is aliasSpec1)) return false;
        if (! base.Equals(o)) return false;
        aliasSpec1 other = (aliasSpec1) o;
        if (! _EOL_KEY.Equals(other._EOL_KEY)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _alias_rhs.Equals(other._alias_rhs)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_EOL_KEY.GetHashCode());
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


