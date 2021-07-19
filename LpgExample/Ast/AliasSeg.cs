namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 4:  LPG_item ::= ALIAS_KEY$ alias_segment END_KEY_OPT$
 *</b>
 */
public class AliasSeg : ASTNode , ILPG_item
{
    private aliasSpecList _alias_segment;

    public aliasSpecList getalias_segment() { return _alias_segment; }
    public void setalias_segment(aliasSpecList _alias_segment) { this._alias_segment = _alias_segment; }

    public AliasSeg(IToken leftIToken, IToken rightIToken,
                    aliasSpecList _alias_segment)
        :base(leftIToken, rightIToken)

    {
        this._alias_segment = _alias_segment;
        ((ASTNode) _alias_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_alias_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is AliasSeg)) return false;
        if (! base.Equals(o)) return false;
        AliasSeg other = (AliasSeg) o;
        if (! _alias_segment.Equals(other._alias_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_alias_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


