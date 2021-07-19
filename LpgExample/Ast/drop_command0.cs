namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 73:  drop_command ::= DROPSYMBOLS_KEY drop_symbols
 *</b>
 */
public class drop_command0 : ASTNode , Idrop_command
{
    private ASTNodeToken _DROPSYMBOLS_KEY;
    private SYMBOLList _drop_symbols;

    public ASTNodeToken getDROPSYMBOLS_KEY() { return _DROPSYMBOLS_KEY; }
    public void setDROPSYMBOLS_KEY(ASTNodeToken _DROPSYMBOLS_KEY) { this._DROPSYMBOLS_KEY = _DROPSYMBOLS_KEY; }
    public SYMBOLList getdrop_symbols() { return _drop_symbols; }
    public void setdrop_symbols(SYMBOLList _drop_symbols) { this._drop_symbols = _drop_symbols; }

    public drop_command0(IToken leftIToken, IToken rightIToken,
                         ASTNodeToken _DROPSYMBOLS_KEY,
                         SYMBOLList _drop_symbols)
        :base(leftIToken, rightIToken)

    {
        this._DROPSYMBOLS_KEY = _DROPSYMBOLS_KEY;
        ((ASTNode) _DROPSYMBOLS_KEY).setParent(this);
        this._drop_symbols = _drop_symbols;
        ((ASTNode) _drop_symbols).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_DROPSYMBOLS_KEY);
        list.Add(_drop_symbols);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is drop_command0)) return false;
        if (! base.Equals(o)) return false;
        drop_command0 other = (drop_command0) o;
        if (! _DROPSYMBOLS_KEY.Equals(other._DROPSYMBOLS_KEY)) return false;
        if (! _drop_symbols.Equals(other._drop_symbols)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_DROPSYMBOLS_KEY.GetHashCode());
        hash = hash * 31 + (_drop_symbols.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


