namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 10:  LPG_item ::= EXPORT_KEY$ export_segment END_KEY_OPT$
 *</b>
 */
public class ExportSeg : ASTNode , ILPG_item
{
    private terminal_symbolList _export_segment;

    public terminal_symbolList getexport_segment() { return _export_segment; }
    public void setexport_segment(terminal_symbolList _export_segment) { this._export_segment = _export_segment; }

    public ExportSeg(IToken leftIToken, IToken rightIToken,
                     terminal_symbolList _export_segment)
        :base(leftIToken, rightIToken)

    {
        this._export_segment = _export_segment;
        ((ASTNode) _export_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_export_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is ExportSeg)) return false;
        if (! base.Equals(o)) return false;
        ExportSeg other = (ExportSeg) o;
        if (! _export_segment.Equals(other._export_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_export_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


