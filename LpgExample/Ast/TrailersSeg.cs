namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 23:  LPG_item ::= TRAILERS_KEY$ trailers_segment END_KEY_OPT$
 *</b>
 */
public class TrailersSeg : ASTNode , ILPG_item
{
    private action_segmentList _trailers_segment;

    public action_segmentList gettrailers_segment() { return _trailers_segment; }
    public void settrailers_segment(action_segmentList _trailers_segment) { this._trailers_segment = _trailers_segment; }

    public TrailersSeg(IToken leftIToken, IToken rightIToken,
                       action_segmentList _trailers_segment)
        :base(leftIToken, rightIToken)

    {
        this._trailers_segment = _trailers_segment;
        ((ASTNode) _trailers_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_trailers_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is TrailersSeg)) return false;
        if (! base.Equals(o)) return false;
        TrailersSeg other = (TrailersSeg) o;
        if (! _trailers_segment.Equals(other._trailers_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_trailers_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


