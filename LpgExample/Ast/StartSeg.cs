namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 21:  LPG_item ::= START_KEY$ start_segment END_KEY_OPT$
 *</b>
 */
public class StartSeg : ASTNode , ILPG_item
{
    private start_symbolList _start_segment;

    public start_symbolList getstart_segment() { return _start_segment; }
    public void setstart_segment(start_symbolList _start_segment) { this._start_segment = _start_segment; }

    public StartSeg(IToken leftIToken, IToken rightIToken,
                    start_symbolList _start_segment)
        :base(leftIToken, rightIToken)

    {
        this._start_segment = _start_segment;
        ((ASTNode) _start_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_start_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is StartSeg)) return false;
        if (! base.Equals(o)) return false;
        StartSeg other = (StartSeg) o;
        if (! _start_segment.Equals(other._start_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_start_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


