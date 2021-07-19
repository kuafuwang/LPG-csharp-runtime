namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 9:  LPG_item ::= ERROR_KEY$ error_segment END_KEY_OPT$
 *</b>
 */
public class ErrorSeg : ASTNode , ILPG_item
{
    private Ierror_segment _error_segment;

    public Ierror_segment geterror_segment() { return _error_segment; }
    public void seterror_segment(Ierror_segment _error_segment) { this._error_segment = _error_segment; }

    public ErrorSeg(IToken leftIToken, IToken rightIToken,
                    Ierror_segment _error_segment)
        :base(leftIToken, rightIToken)

    {
        this._error_segment = _error_segment;
        ((ASTNode) _error_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_error_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is ErrorSeg)) return false;
        if (! base.Equals(o)) return false;
        ErrorSeg other = (ErrorSeg) o;
        if (! _error_segment.Equals(other._error_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_error_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


