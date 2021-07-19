namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 14:  LPG_item ::= IMPORT_KEY$ import_segment END_KEY_OPT$
 *</b>
 */
public class ImportSeg : ASTNode , ILPG_item
{
    private import_segment _import_segment;

    public import_segment getimport_segment() { return _import_segment; }
    public void setimport_segment(import_segment _import_segment) { this._import_segment = _import_segment; }

    public ImportSeg(IToken leftIToken, IToken rightIToken,
                     import_segment _import_segment)
        :base(leftIToken, rightIToken)

    {
        this._import_segment = _import_segment;
        ((ASTNode) _import_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_import_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is ImportSeg)) return false;
        if (! base.Equals(o)) return false;
        ImportSeg other = (ImportSeg) o;
        if (! _import_segment.Equals(other._import_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_import_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


