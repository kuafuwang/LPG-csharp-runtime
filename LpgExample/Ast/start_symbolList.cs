namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 121:  start_segment ::= start_symbol
 *<li>Rule 122:  start_segment ::= start_segment start_symbol
 *</b>
 */
public class start_symbolList : AbstractASTNodeList , Istart_segment
{
    public Istart_symbol getstart_symbolAt(int i) { return (Istart_symbol) getElementAt(i); }

    public start_symbolList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public start_symbolList(Istart_symbol _start_symbol, bool leftRecursive)
        :base((ASTNode) _start_symbol, leftRecursive)
    {
        ((ASTNode) _start_symbol).setParent(this);
    }

    public void addElement(Istart_symbol _start_symbol)
    {
        base.addElement((ASTNode) _start_symbol);
        ((ASTNode) _start_symbol).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is start_symbolList)) return false;
        if (! base.Equals(o)) return false;
        start_symbolList other = (start_symbolList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            Istart_symbol element = getstart_symbolAt(i);
            if (! element.Equals(other.getstart_symbolAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getstart_symbolAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getstart_symbolAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getstart_symbolAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getstart_symbolAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getstart_symbolAt(i).accept(v, o));
        return result;
    }
}
}


