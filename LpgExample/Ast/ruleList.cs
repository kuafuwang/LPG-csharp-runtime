namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 105:  ruleList ::= rule
 *<li>Rule 106:  ruleList ::= ruleList |$ rule
 *</b>
 */
public class ruleList : AbstractASTNodeList , IruleList
{
    public rule getruleAt(int i) { return (rule) getElementAt(i); }

    public ruleList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public ruleList(rule _rule, bool leftRecursive)
        :base((ASTNode) _rule, leftRecursive)
    {
        ((ASTNode) _rule).setParent(this);
    }

    public void addElement(rule _rule)
    {
        base.addElement((ASTNode) _rule);
        ((ASTNode) _rule).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is ruleList)) return false;
        if (! base.Equals(o)) return false;
        ruleList other = (ruleList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            rule element = getruleAt(i);
            if (! element.Equals(other.getruleAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getruleAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getruleAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getruleAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getruleAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getruleAt(i), o));
        return result;
    }
}
}


