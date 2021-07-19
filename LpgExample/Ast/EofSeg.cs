namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 7:  LPG_item ::= EOF_KEY$ eof_segment END_KEY_OPT$
 *</b>
 */
public class EofSeg : ASTNode , ILPG_item
{
    private Ieof_segment _eof_segment;

    public Ieof_segment geteof_segment() { return _eof_segment; }
    public void seteof_segment(Ieof_segment _eof_segment) { this._eof_segment = _eof_segment; }

    public EofSeg(IToken leftIToken, IToken rightIToken,
                  Ieof_segment _eof_segment)
        :base(leftIToken, rightIToken)

    {
        this._eof_segment = _eof_segment;
        ((ASTNode) _eof_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_eof_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is EofSeg)) return false;
        if (! base.Equals(o)) return false;
        EofSeg other = (EofSeg) o;
        if (! _eof_segment.Equals(other._eof_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_eof_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


