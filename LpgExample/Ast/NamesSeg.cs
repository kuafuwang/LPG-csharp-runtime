namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 17:  LPG_item ::= NAMES_KEY$ names_segment END_KEY_OPT$
 *</b>
 */
public class NamesSeg : ASTNode , ILPG_item
{
    private nameSpecList _names_segment;

    public nameSpecList getnames_segment() { return _names_segment; }
    public void setnames_segment(nameSpecList _names_segment) { this._names_segment = _names_segment; }

    public NamesSeg(IToken leftIToken, IToken rightIToken,
                    nameSpecList _names_segment)
        :base(leftIToken, rightIToken)

    {
        this._names_segment = _names_segment;
        ((ASTNode) _names_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_names_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is NamesSeg)) return false;
        if (! base.Equals(o)) return false;
        NamesSeg other = (NamesSeg) o;
        if (! _names_segment.Equals(other._names_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_names_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


