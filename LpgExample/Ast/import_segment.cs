namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 70:  import_segment ::= SYMBOL drop_command_list
 *</b>
 */
public class import_segment : ASTNode , Iimport_segment
{
    private ASTNodeToken _SYMBOL;
    private drop_commandList _drop_command_list;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    public drop_commandList getdrop_command_list() { return _drop_command_list; }
    public void setdrop_command_list(drop_commandList _drop_command_list) { this._drop_command_list = _drop_command_list; }

    public import_segment(IToken leftIToken, IToken rightIToken,
                          ASTNodeToken _SYMBOL,
                          drop_commandList _drop_command_list)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._drop_command_list = _drop_command_list;
        ((ASTNode) _drop_command_list).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        list.Add(_drop_command_list);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is import_segment)) return false;
        if (! base.Equals(o)) return false;
        import_segment other = (import_segment) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (! _drop_command_list.Equals(other._drop_command_list)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_drop_command_list.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


