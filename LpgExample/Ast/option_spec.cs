namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 29:  option_spec ::= OPTIONS_KEY$ option_list
 *</b>
 */
public class option_spec : ASTNode , Ioption_spec
{
    private optionList _option_list;

    public optionList getoption_list() { return _option_list; }
    public void setoption_list(optionList _option_list) { this._option_list = _option_list; }

    public option_spec(IToken leftIToken, IToken rightIToken,
                       optionList _option_list)
        :base(leftIToken, rightIToken)

    {
        this._option_list = _option_list;
        ((ASTNode) _option_list).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_option_list);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is option_spec)) return false;
        if (! base.Equals(o)) return false;
        option_spec other = (option_spec) o;
        if (! _option_list.Equals(other._option_list)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_option_list.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


