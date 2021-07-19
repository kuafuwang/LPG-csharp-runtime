namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 34:  option_value ::= =$ SYMBOL
 *</b>
 */
public class option_value0 : ASTNode , Ioption_value
{
    private ASTNodeToken _SYMBOL;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }

    public option_value0(IToken leftIToken, IToken rightIToken,
                         ASTNodeToken _SYMBOL)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is option_value0)) return false;
        if (! base.Equals(o)) return false;
        option_value0 other = (option_value0) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


