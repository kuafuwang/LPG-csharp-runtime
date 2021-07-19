namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 112:  symWithAttrsList ::= $Empty
 *<li>Rule 113:  symWithAttrsList ::= symWithAttrsList symWithAttrs
 *</b>
 */
public class symWithAttrsList : AbstractASTNodeList , IsymWithAttrsList
{
    public IsymWithAttrs getsymWithAttrsAt(int i) { return (IsymWithAttrs) getElementAt(i); }

    public symWithAttrsList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public symWithAttrsList(IsymWithAttrs _symWithAttrs, bool leftRecursive)
        :base((ASTNode) _symWithAttrs, leftRecursive)
    {
        ((ASTNode) _symWithAttrs).setParent(this);
    }

    public void addElement(IsymWithAttrs _symWithAttrs)
    {
        base.addElement((ASTNode) _symWithAttrs);
        ((ASTNode) _symWithAttrs).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is symWithAttrsList)) return false;
        if (! base.Equals(o)) return false;
        symWithAttrsList other = (symWithAttrsList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            IsymWithAttrs element = getsymWithAttrsAt(i);
            if (! element.Equals(other.getsymWithAttrsAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getsymWithAttrsAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getsymWithAttrsAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getsymWithAttrsAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getsymWithAttrsAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getsymWithAttrsAt(i).accept(v, o));
        return result;
    }
}
}


