namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 36:  symbol_list ::= SYMBOL
 *<li>Rule 37:  symbol_list ::= symbol_list ,$ SYMBOL
 *<li>Rule 75:  drop_symbols ::= SYMBOL
 *<li>Rule 76:  drop_symbols ::= drop_symbols SYMBOL
 *<li>Rule 136:  barSymbolList ::= SYMBOL
 *<li>Rule 137:  barSymbolList ::= barSymbolList |$ SYMBOL
 *<li>Rule 141:  recover_segment ::= $Empty
 *<li>Rule 142:  recover_segment ::= recover_segment recover_symbol
 *</b>
 */
public class SYMBOLList : AbstractASTNodeList , Isymbol_list, Idrop_symbols, IbarSymbolList, Irecover_segment
{
    public ASTNodeToken getSYMBOLAt(int i) { return (ASTNodeToken) getElementAt(i); }

    public SYMBOLList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public SYMBOLList(ASTNodeToken _SYMBOL, bool leftRecursive)
        :base((ASTNode) _SYMBOL, leftRecursive)
    {
        ((ASTNode) _SYMBOL).setParent(this);
    }

    public void addElement(ASTNodeToken _SYMBOL)
    {
        base.addElement((ASTNode) _SYMBOL);
        ((ASTNode) _SYMBOL).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is SYMBOLList)) return false;
        if (! base.Equals(o)) return false;
        SYMBOLList other = (SYMBOLList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            ASTNodeToken element = getSYMBOLAt(i);
            if (! element.Equals(other.getSYMBOLAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getSYMBOLAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getSYMBOLAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getSYMBOLAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getSYMBOLAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getSYMBOLAt(i), o));
        return result;
    }
}
}


