namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 87:  names_segment ::= nameSpec
 *<li>Rule 88:  names_segment ::= names_segment nameSpec
 *</b>
 */
public class nameSpecList : AbstractASTNodeList , Inames_segment
{
    public nameSpec getnameSpecAt(int i) { return (nameSpec) getElementAt(i); }

    public nameSpecList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public nameSpecList(nameSpec _nameSpec, bool leftRecursive)
        :base((ASTNode) _nameSpec, leftRecursive)
    {
        ((ASTNode) _nameSpec).setParent(this);
    }

    public void addElement(nameSpec _nameSpec)
    {
        base.addElement((ASTNode) _nameSpec);
        ((ASTNode) _nameSpec).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is nameSpecList)) return false;
        if (! base.Equals(o)) return false;
        nameSpecList other = (nameSpecList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            nameSpec element = getnameSpecAt(i);
            if (! element.Equals(other.getnameSpecAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getnameSpecAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getnameSpecAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getnameSpecAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getnameSpecAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getnameSpecAt(i), o));
        return result;
    }
}
}


