namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 45:  aliasSpec ::= alias_lhs_macro_name produces alias_rhs
 *</b>
 */
public class aliasSpec5 : ASTNode , IaliasSpec
{
    private alias_lhs_macro_name _alias_lhs_macro_name;
    private Iproduces _produces;
    private Ialias_rhs _alias_rhs;

    public alias_lhs_macro_name getalias_lhs_macro_name() { return _alias_lhs_macro_name; }
    public void setalias_lhs_macro_name(alias_lhs_macro_name _alias_lhs_macro_name) { this._alias_lhs_macro_name = _alias_lhs_macro_name; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public Ialias_rhs getalias_rhs() { return _alias_rhs; }
    public void setalias_rhs(Ialias_rhs _alias_rhs) { this._alias_rhs = _alias_rhs; }

    public aliasSpec5(IToken leftIToken, IToken rightIToken,
                      alias_lhs_macro_name _alias_lhs_macro_name,
                      Iproduces _produces,
                      Ialias_rhs _alias_rhs)
        :base(leftIToken, rightIToken)

    {
        this._alias_lhs_macro_name = _alias_lhs_macro_name;
        ((ASTNode) _alias_lhs_macro_name).setParent(this);
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
        list.Add(_alias_lhs_macro_name);
        list.Add(_produces);
        list.Add(_alias_rhs);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is aliasSpec5)) return false;
        if (! base.Equals(o)) return false;
        aliasSpec5 other = (aliasSpec5) o;
        if (! _alias_lhs_macro_name.Equals(other._alias_lhs_macro_name)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _alias_rhs.Equals(other._alias_rhs)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_alias_lhs_macro_name.GetHashCode());
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


