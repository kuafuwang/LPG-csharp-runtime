namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 2:  LPG_INPUT ::= $Empty
 *<li>Rule 3:  LPG_INPUT ::= LPG_INPUT LPG_item
 *</b>
 */
public class LPG_itemList : AbstractASTNodeList , ILPG_INPUT
{
    public ILPG_item getLPG_itemAt(int i) { return (ILPG_item) getElementAt(i); }

    public LPG_itemList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public LPG_itemList(ILPG_item _LPG_item, bool leftRecursive)
        :base((ASTNode) _LPG_item, leftRecursive)
    {
        ((ASTNode) _LPG_item).setParent(this);
    }

    public void addElement(ILPG_item _LPG_item)
    {
        base.addElement((ASTNode) _LPG_item);
        ((ASTNode) _LPG_item).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is LPG_itemList)) return false;
        if (! base.Equals(o)) return false;
        LPG_itemList other = (LPG_itemList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            ILPG_item element = getLPG_itemAt(i);
            if (! element.Equals(other.getLPG_itemAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getLPG_itemAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getLPG_itemAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getLPG_itemAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getLPG_itemAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getLPG_itemAt(i).accept(v, o));
        return result;
    }
}
}


