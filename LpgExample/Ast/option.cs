namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 32:  option ::= SYMBOL option_value
 *</b>
 */
public class option : ASTNode , Ioption
{
    private ASTNodeToken _SYMBOL;
    private Ioption_value _option_value;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    /**
     * The value returned by <b>getoption_value</b> may be <b>null</b>
     */
    public Ioption_value getoption_value() { return _option_value; }
    public void setoption_value(Ioption_value _option_value) { this._option_value = _option_value; }

    public option(IToken leftIToken, IToken rightIToken,
                  ASTNodeToken _SYMBOL,
                  Ioption_value _option_value)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._option_value = _option_value;
        if (_option_value != null) ((ASTNode) _option_value).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        list.Add(_option_value);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is option)) return false;
        if (! base.Equals(o)) return false;
        option other = (option) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (_option_value == null)
            if (other._option_value != null) return false;
            else{}// continue
        else if (! _option_value.Equals(other._option_value)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_option_value == null ? 0 : _option_value.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


