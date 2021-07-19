namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 15:  LPG_item ::= INCLUDE_KEY$ include_segment END_KEY_OPT$
 *</b>
 */
public class IncludeSeg : ASTNode , ILPG_item
{
    private include_segment _include_segment;

    public include_segment getinclude_segment() { return _include_segment; }
    public void setinclude_segment(include_segment _include_segment) { this._include_segment = _include_segment; }

    public IncludeSeg(IToken leftIToken, IToken rightIToken,
                      include_segment _include_segment)
        :base(leftIToken, rightIToken)

    {
        this._include_segment = _include_segment;
        ((ASTNode) _include_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_include_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is IncludeSeg)) return false;
        if (! base.Equals(o)) return false;
        IncludeSeg other = (IncludeSeg) o;
        if (! _include_segment.Equals(other._include_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_include_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


