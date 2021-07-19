namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 40:  aliasSpec ::= ERROR_KEY produces alias_rhs
 *</b>
 */
public class aliasSpec0 : ASTNode , IaliasSpec
{
    private ASTNodeToken _ERROR_KEY;
    private Iproduces _produces;
    private Ialias_rhs _alias_rhs;

    public ASTNodeToken getERROR_KEY() { return _ERROR_KEY; }
    public void setERROR_KEY(ASTNodeToken _ERROR_KEY) { this._ERROR_KEY = _ERROR_KEY; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public Ialias_rhs getalias_rhs() { return _alias_rhs; }
    public void setalias_rhs(Ialias_rhs _alias_rhs) { this._alias_rhs = _alias_rhs; }

    public aliasSpec0(IToken leftIToken, IToken rightIToken,
                      ASTNodeToken _ERROR_KEY,
                      Iproduces _produces,
                      Ialias_rhs _alias_rhs)
        :base(leftIToken, rightIToken)

    {
        this._ERROR_KEY = _ERROR_KEY;
        ((ASTNode) _ERROR_KEY).setParent(this);
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
        list.Add(_ERROR_KEY);
        list.Add(_produces);
        list.Add(_alias_rhs);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is aliasSpec0)) return false;
        if (! base.Equals(o)) return false;
        aliasSpec0 other = (aliasSpec0) o;
        if (! _ERROR_KEY.Equals(other._ERROR_KEY)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _alias_rhs.Equals(other._alias_rhs)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_ERROR_KEY.GetHashCode());
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


