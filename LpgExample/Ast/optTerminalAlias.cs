namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<em>
 *<li>Rule 128:  optTerminalAlias ::= $Empty
 *</em>
 *<p>
 *<b>
 *<li>Rule 129:  optTerminalAlias ::= produces name
 *</b>
 */
public class optTerminalAlias : ASTNode , IoptTerminalAlias
{
    private Iproduces _produces;
    private Iname _name;

    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public Iname getname() { return _name; }
    public void setname(Iname _name) { this._name = _name; }

    public optTerminalAlias(IToken leftIToken, IToken rightIToken,
                            Iproduces _produces,
                            Iname _name)
        :base(leftIToken, rightIToken)

    {
        this._produces = _produces;
        ((ASTNode) _produces).setParent(this);
        this._name = _name;
        ((ASTNode) _name).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_produces);
        list.Add(_name);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is optTerminalAlias)) return false;
        if (! base.Equals(o)) return false;
        optTerminalAlias other = (optTerminalAlias) o;
        if (! _produces.Equals(other._produces)) return false;
        if (! _name.Equals(other._name)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_produces.GetHashCode());
        hash = hash * 31 + (_name.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


