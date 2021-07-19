namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 24:  LPG_item ::= TYPES_KEY$ types_segment END_KEY_OPT$
 *</b>
 */
public class TypesSeg : ASTNode , ILPG_item
{
    private type_declarationsList _types_segment;

    public type_declarationsList gettypes_segment() { return _types_segment; }
    public void settypes_segment(type_declarationsList _types_segment) { this._types_segment = _types_segment; }

    public TypesSeg(IToken leftIToken, IToken rightIToken,
                    type_declarationsList _types_segment)
        :base(leftIToken, rightIToken)

    {
        this._types_segment = _types_segment;
        ((ASTNode) _types_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_types_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is TypesSeg)) return false;
        if (! base.Equals(o)) return false;
        TypesSeg other = (TypesSeg) o;
        if (! _types_segment.Equals(other._types_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_types_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


