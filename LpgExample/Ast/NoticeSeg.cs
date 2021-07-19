namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 18:  LPG_item ::= NOTICE_KEY$ notice_segment END_KEY_OPT$
 *</b>
 */
public class NoticeSeg : ASTNode , ILPG_item
{
    private action_segmentList _notice_segment;

    public action_segmentList getnotice_segment() { return _notice_segment; }
    public void setnotice_segment(action_segmentList _notice_segment) { this._notice_segment = _notice_segment; }

    public NoticeSeg(IToken leftIToken, IToken rightIToken,
                     action_segmentList _notice_segment)
        :base(leftIToken, rightIToken)

    {
        this._notice_segment = _notice_segment;
        ((ASTNode) _notice_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_notice_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is NoticeSeg)) return false;
        if (! base.Equals(o)) return false;
        NoticeSeg other = (NoticeSeg) o;
        if (! _notice_segment.Equals(other._notice_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_notice_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


