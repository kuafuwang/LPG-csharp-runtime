namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 12:  LPG_item ::= HEADERS_KEY$ headers_segment END_KEY_OPT$
 *</b>
 */
public class HeadersSeg : ASTNode , ILPG_item
{
    private action_segmentList _headers_segment;

    public action_segmentList getheaders_segment() { return _headers_segment; }
    public void setheaders_segment(action_segmentList _headers_segment) { this._headers_segment = _headers_segment; }

    public HeadersSeg(IToken leftIToken, IToken rightIToken,
                      action_segmentList _headers_segment)
        :base(leftIToken, rightIToken)

    {
        this._headers_segment = _headers_segment;
        ((ASTNode) _headers_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_headers_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is HeadersSeg)) return false;
        if (! base.Equals(o)) return false;
        HeadersSeg other = (HeadersSeg) o;
        if (! _headers_segment.Equals(other._headers_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_headers_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


