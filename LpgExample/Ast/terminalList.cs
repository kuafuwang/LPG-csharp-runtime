namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 125:  terminals_segment ::= terminal
 *<li>Rule 126:  terminals_segment ::= terminals_segment terminal
 *</b>
 */
public class terminalList : AbstractASTNodeList , Iterminals_segment
{
    public terminal getterminalAt(int i) { return (terminal) getElementAt(i); }

    public terminalList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public terminalList(terminal _terminal, bool leftRecursive)
        :base((ASTNode) _terminal, leftRecursive)
    {
        ((ASTNode) _terminal).setParent(this);
    }

    public void addElement(terminal _terminal)
    {
        base.addElement((ASTNode) _terminal);
        ((ASTNode) _terminal).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is terminalList)) return false;
        if (! base.Equals(o)) return false;
        terminalList other = (terminalList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            terminal element = getterminalAt(i);
            if (! element.Equals(other.getterminalAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getterminalAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getterminalAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getterminalAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getterminalAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getterminalAt(i), o));
        return result;
    }
}
}


