namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 13:  LPG_item ::= IDENTIFIER_KEY$ identifier_segment END_KEY_OPT$
 *</b>
 */
public class IdentifierSeg : ASTNode , ILPG_item
{
    private Iidentifier_segment _identifier_segment;

    public Iidentifier_segment getidentifier_segment() { return _identifier_segment; }
    public void setidentifier_segment(Iidentifier_segment _identifier_segment) { this._identifier_segment = _identifier_segment; }

    public IdentifierSeg(IToken leftIToken, IToken rightIToken,
                         Iidentifier_segment _identifier_segment)
        :base(leftIToken, rightIToken)

    {
        this._identifier_segment = _identifier_segment;
        ((ASTNode) _identifier_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_identifier_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is IdentifierSeg)) return false;
        if (! base.Equals(o)) return false;
        IdentifierSeg other = (IdentifierSeg) o;
        if (! _identifier_segment.Equals(other._identifier_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_identifier_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


