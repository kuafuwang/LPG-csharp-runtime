namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 5:  LPG_item ::= AST_KEY$ ast_segment END_KEY_OPT$
 *</b>
 */
public class AstSeg : ASTNode , ILPG_item
{
    private action_segmentList _ast_segment;

    public action_segmentList getast_segment() { return _ast_segment; }
    public void setast_segment(action_segmentList _ast_segment) { this._ast_segment = _ast_segment; }

    public AstSeg(IToken leftIToken, IToken rightIToken,
                  action_segmentList _ast_segment)
        :base(leftIToken, rightIToken)

    {
        this._ast_segment = _ast_segment;
        ((ASTNode) _ast_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_ast_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is AstSeg)) return false;
        if (! base.Equals(o)) return false;
        AstSeg other = (AstSeg) o;
        if (! _ast_segment.Equals(other._ast_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_ast_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


