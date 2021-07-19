namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 99:  nonTermList ::= $Empty
 *<li>Rule 100:  nonTermList ::= nonTermList nonTerm
 *</b>
 */
public class nonTermList : AbstractASTNodeList , InonTermList
{
    public nonTerm getnonTermAt(int i) { return (nonTerm) getElementAt(i); }

    public nonTermList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public nonTermList(nonTerm _nonTerm, bool leftRecursive)
        :base((ASTNode) _nonTerm, leftRecursive)
    {
        ((ASTNode) _nonTerm).setParent(this);
    }

    public void addElement(nonTerm _nonTerm)
    {
        base.addElement((ASTNode) _nonTerm);
        ((ASTNode) _nonTerm).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is nonTermList)) return false;
        if (! base.Equals(o)) return false;
        nonTermList other = (nonTermList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            nonTerm element = getnonTermAt(i);
            if (! element.Equals(other.getnonTermAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getnonTermAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getnonTermAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getnonTermAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getnonTermAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getnonTermAt(i), o));
        return result;
    }
}
}


