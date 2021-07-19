namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 26:  LPG_item ::= DISJOINTPREDECESSORSETS_KEY$ predecessor_segment END_KEY_OPT$
 *</b>
 */
public class PredecessorSeg : ASTNode , ILPG_item
{
    private symbol_pairList _predecessor_segment;

    public symbol_pairList getpredecessor_segment() { return _predecessor_segment; }
    public void setpredecessor_segment(symbol_pairList _predecessor_segment) { this._predecessor_segment = _predecessor_segment; }

    public PredecessorSeg(IToken leftIToken, IToken rightIToken,
                          symbol_pairList _predecessor_segment)
        :base(leftIToken, rightIToken)

    {
        this._predecessor_segment = _predecessor_segment;
        ((ASTNode) _predecessor_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_predecessor_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is PredecessorSeg)) return false;
        if (! base.Equals(o)) return false;
        PredecessorSeg other = (PredecessorSeg) o;
        if (! _predecessor_segment.Equals(other._predecessor_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_predecessor_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


