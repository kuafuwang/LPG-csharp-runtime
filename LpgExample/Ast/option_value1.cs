namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 35:  option_value ::= =$ ($ symbol_list )$
 *</b>
 */
public class option_value1 : ASTNode , Ioption_value
{
    private SYMBOLList _symbol_list;

    public SYMBOLList getsymbol_list() { return _symbol_list; }
    public void setsymbol_list(SYMBOLList _symbol_list) { this._symbol_list = _symbol_list; }

    public option_value1(IToken leftIToken, IToken rightIToken,
                         SYMBOLList _symbol_list)
        :base(leftIToken, rightIToken)

    {
        this._symbol_list = _symbol_list;
        ((ASTNode) _symbol_list).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_symbol_list);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is option_value1)) return false;
        if (! base.Equals(o)) return false;
        option_value1 other = (option_value1) o;
        if (! _symbol_list.Equals(other._symbol_list)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_symbol_list.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


