namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 22:  LPG_item ::= TERMINALS_KEY$ terminals_segment END_KEY_OPT$
 *</b>
 */
public class TerminalsSeg : ASTNode , ILPG_item
{
    private terminalList _terminals_segment;

    public terminalList getterminals_segment() { return _terminals_segment; }
    public void setterminals_segment(terminalList _terminals_segment) { this._terminals_segment = _terminals_segment; }

    public TerminalsSeg(IToken leftIToken, IToken rightIToken,
                        terminalList _terminals_segment)
        :base(leftIToken, rightIToken)

    {
        this._terminals_segment = _terminals_segment;
        ((ASTNode) _terminals_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_terminals_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is TerminalsSeg)) return false;
        if (! base.Equals(o)) return false;
        TerminalsSeg other = (TerminalsSeg) o;
        if (! _terminals_segment.Equals(other._terminals_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_terminals_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


