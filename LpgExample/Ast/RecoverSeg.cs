namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 25:  LPG_item ::= RECOVER_KEY$ recover_segment END_KEY_OPT$
 *</b>
 */
public class RecoverSeg : ASTNode , ILPG_item
{
    private SYMBOLList _recover_segment;

    public SYMBOLList getrecover_segment() { return _recover_segment; }
    public void setrecover_segment(SYMBOLList _recover_segment) { this._recover_segment = _recover_segment; }

    public RecoverSeg(IToken leftIToken, IToken rightIToken,
                      SYMBOLList _recover_segment)
        :base(leftIToken, rightIToken)

    {
        this._recover_segment = _recover_segment;
        ((ASTNode) _recover_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_recover_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is RecoverSeg)) return false;
        if (! base.Equals(o)) return false;
        RecoverSeg other = (RecoverSeg) o;
        if (! _recover_segment.Equals(other._recover_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_recover_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


