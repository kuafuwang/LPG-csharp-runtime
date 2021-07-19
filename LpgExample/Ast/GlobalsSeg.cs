namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 11:  LPG_item ::= GLOBALS_KEY$ globals_segment END_KEY_OPT$
 *</b>
 */
public class GlobalsSeg : ASTNode , ILPG_item
{
    private action_segmentList _globals_segment;

    public action_segmentList getglobals_segment() { return _globals_segment; }
    public void setglobals_segment(action_segmentList _globals_segment) { this._globals_segment = _globals_segment; }

    public GlobalsSeg(IToken leftIToken, IToken rightIToken,
                      action_segmentList _globals_segment)
        :base(leftIToken, rightIToken)

    {
        this._globals_segment = _globals_segment;
        ((ASTNode) _globals_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_globals_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is GlobalsSeg)) return false;
        if (! base.Equals(o)) return false;
        GlobalsSeg other = (GlobalsSeg) o;
        if (! _globals_segment.Equals(other._globals_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_globals_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


