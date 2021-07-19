namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 8:  LPG_item ::= EOL_KEY$ eol_segment END_KEY_OPT$
 *</b>
 */
public class EolSeg : ASTNode , ILPG_item
{
    private Ieol_segment _eol_segment;

    public Ieol_segment geteol_segment() { return _eol_segment; }
    public void seteol_segment(Ieol_segment _eol_segment) { this._eol_segment = _eol_segment; }

    public EolSeg(IToken leftIToken, IToken rightIToken,
                  Ieol_segment _eol_segment)
        :base(leftIToken, rightIToken)

    {
        this._eol_segment = _eol_segment;
        ((ASTNode) _eol_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_eol_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is EolSeg)) return false;
        if (! base.Equals(o)) return false;
        EolSeg other = (EolSeg) o;
        if (! _eol_segment.Equals(other._eol_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_eol_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


