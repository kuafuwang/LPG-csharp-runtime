namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 6:  LPG_item ::= DEFINE_KEY$ define_segment END_KEY_OPT$
 *</b>
 */
public class DefineSeg : ASTNode , ILPG_item
{
    private defineSpecList _define_segment;

    public defineSpecList getdefine_segment() { return _define_segment; }
    public void setdefine_segment(defineSpecList _define_segment) { this._define_segment = _define_segment; }

    public DefineSeg(IToken leftIToken, IToken rightIToken,
                     defineSpecList _define_segment)
        :base(leftIToken, rightIToken)

    {
        this._define_segment = _define_segment;
        ((ASTNode) _define_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_define_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is DefineSeg)) return false;
        if (! base.Equals(o)) return false;
        DefineSeg other = (DefineSeg) o;
        if (! _define_segment.Equals(other._define_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_define_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


