namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 138:  predecessor_segment ::= $Empty
 *<li>Rule 139:  predecessor_segment ::= predecessor_segment symbol_pair
 *</b>
 */
public class symbol_pairList : AbstractASTNodeList , Ipredecessor_segment
{
    public symbol_pair getsymbol_pairAt(int i) { return (symbol_pair) getElementAt(i); }

    public symbol_pairList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public symbol_pairList(symbol_pair _symbol_pair, bool leftRecursive)
        :base((ASTNode) _symbol_pair, leftRecursive)
    {
        ((ASTNode) _symbol_pair).setParent(this);
    }

    public void addElement(symbol_pair _symbol_pair)
    {
        base.addElement((ASTNode) _symbol_pair);
        ((ASTNode) _symbol_pair).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is symbol_pairList)) return false;
        if (! base.Equals(o)) return false;
        symbol_pairList other = (symbol_pairList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            symbol_pair element = getsymbol_pairAt(i);
            if (! element.Equals(other.getsymbol_pairAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getsymbol_pairAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getsymbol_pairAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getsymbol_pairAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getsymbol_pairAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getsymbol_pairAt(i), o));
        return result;
    }
}
}


