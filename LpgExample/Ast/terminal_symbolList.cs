namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 64:  export_segment ::= terminal_symbol
 *<li>Rule 65:  export_segment ::= export_segment terminal_symbol
 *</b>
 */
public class terminal_symbolList : AbstractASTNodeList , Iexport_segment
{
    public Iterminal_symbol getterminal_symbolAt(int i) { return (Iterminal_symbol) getElementAt(i); }

    public terminal_symbolList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public terminal_symbolList(Iterminal_symbol _terminal_symbol, bool leftRecursive)
        :base((ASTNode) _terminal_symbol, leftRecursive)
    {
        ((ASTNode) _terminal_symbol).setParent(this);
    }

    public void addElement(Iterminal_symbol _terminal_symbol)
    {
        base.addElement((ASTNode) _terminal_symbol);
        ((ASTNode) _terminal_symbol).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is terminal_symbolList)) return false;
        if (! base.Equals(o)) return false;
        terminal_symbolList other = (terminal_symbolList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            Iterminal_symbol element = getterminal_symbolAt(i);
            if (! element.Equals(other.getterminal_symbolAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getterminal_symbolAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getterminal_symbolAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getterminal_symbolAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getterminal_symbolAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getterminal_symbolAt(i).accept(v, o));
        return result;
    }
}
}


