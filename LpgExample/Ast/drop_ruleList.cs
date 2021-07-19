namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 77:  drop_rules ::= drop_rule
 *<li>Rule 78:  drop_rules ::= drop_rules drop_rule
 *</b>
 */
public class drop_ruleList : AbstractASTNodeList , Idrop_rules
{
    public drop_rule getdrop_ruleAt(int i) { return (drop_rule) getElementAt(i); }

    public drop_ruleList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public drop_ruleList(drop_rule _drop_rule, bool leftRecursive)
        :base((ASTNode) _drop_rule, leftRecursive)
    {
        ((ASTNode) _drop_rule).setParent(this);
    }

    public void addElement(drop_rule _drop_rule)
    {
        base.addElement((ASTNode) _drop_rule);
        ((ASTNode) _drop_rule).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is drop_ruleList)) return false;
        if (! base.Equals(o)) return false;
        drop_ruleList other = (drop_ruleList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            drop_rule element = getdrop_ruleAt(i);
            if (! element.Equals(other.getdrop_ruleAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getdrop_ruleAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getdrop_ruleAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getdrop_ruleAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getdrop_ruleAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getdrop_ruleAt(i), o));
        return result;
    }
}
}


