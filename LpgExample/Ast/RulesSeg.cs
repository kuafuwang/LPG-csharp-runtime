namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 19:  LPG_item ::= RULES_KEY$ rules_segment END_KEY_OPT$
 *</b>
 */
public class RulesSeg : ASTNode , ILPG_item
{
    private rules_segment _rules_segment;

    public rules_segment getrules_segment() { return _rules_segment; }
    public void setrules_segment(rules_segment _rules_segment) { this._rules_segment = _rules_segment; }

    public RulesSeg(IToken leftIToken, IToken rightIToken,
                    rules_segment _rules_segment)
        :base(leftIToken, rightIToken)

    {
        this._rules_segment = _rules_segment;
        ((ASTNode) _rules_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_rules_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is RulesSeg)) return false;
        if (! base.Equals(o)) return false;
        RulesSeg other = (RulesSeg) o;
        if (! _rules_segment.Equals(other._rules_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_rules_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


