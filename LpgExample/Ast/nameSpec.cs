namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 89:  nameSpec ::= name produces name
 *</b>
 */
public class nameSpec : ASTNode , InameSpec
{
    private Iname _name;
    private Iproduces _produces;
    private Iname _name3;

    public Iname getname() { return _name; }
    public void setname(Iname _name) { this._name = _name; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public Iname getname3() { return _name3; }
    public void setname3(Iname _name3) { this._name3 = _name3; }

    public nameSpec(IToken leftIToken, IToken rightIToken,
                    Iname _name,
                    Iproduces _produces,
                    Iname _name3)
        :base(leftIToken, rightIToken)

    {
        this._name = _name;
        ((ASTNode) _name).setParent(this);
        this._produces = _produces;
        ((ASTNode) _produces).setParent(this);
        this._name3 = _name3;
        ((ASTNode) _name3).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_name);
        list.Add(_produces);
        list.Add(_name3);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is nameSpec)) return false;
        if (! base.Equals(o)) return false;
        nameSpec other = (nameSpec) o;
        if (! _name.Equals(other._name)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _name3.Equals(other._name3)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_name.GetHashCode());
        hash = hash * 31 + (_produces.GetHashCode());
        hash = hash * 31 + (_name3.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


