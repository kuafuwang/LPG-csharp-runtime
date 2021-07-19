namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 57:  defineSpec ::= macro_name_symbol macro_segment
 *</b>
 */
public class defineSpec : ASTNode , IdefineSpec
{
    private Imacro_name_symbol _macro_name_symbol;
    private macro_segment _macro_segment;

    public Imacro_name_symbol getmacro_name_symbol() { return _macro_name_symbol; }
    public void setmacro_name_symbol(Imacro_name_symbol _macro_name_symbol) { this._macro_name_symbol = _macro_name_symbol; }
    public macro_segment getmacro_segment() { return _macro_segment; }
    public void setmacro_segment(macro_segment _macro_segment) { this._macro_segment = _macro_segment; }

    public defineSpec(IToken leftIToken, IToken rightIToken,
                      Imacro_name_symbol _macro_name_symbol,
                      macro_segment _macro_segment)
        :base(leftIToken, rightIToken)

    {
        this._macro_name_symbol = _macro_name_symbol;
        ((ASTNode) _macro_name_symbol).setParent(this);
        this._macro_segment = _macro_segment;
        ((ASTNode) _macro_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_macro_name_symbol);
        list.Add(_macro_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is defineSpec)) return false;
        if (! base.Equals(o)) return false;
        defineSpec other = (defineSpec) o;
        if (! _macro_name_symbol.Equals(other._macro_name_symbol)) return false;
        if (! _macro_segment.Equals(other._macro_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_macro_name_symbol.GetHashCode());
        hash = hash * 31 + (_macro_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


