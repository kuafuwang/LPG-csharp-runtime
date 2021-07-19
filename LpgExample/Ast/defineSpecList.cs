namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 55:  define_segment ::= defineSpec
 *<li>Rule 56:  define_segment ::= define_segment defineSpec
 *</b>
 */
public class defineSpecList : AbstractASTNodeList , Idefine_segment
{
    public defineSpec getdefineSpecAt(int i) { return (defineSpec) getElementAt(i); }

    public defineSpecList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public defineSpecList(defineSpec _defineSpec, bool leftRecursive)
        :base((ASTNode) _defineSpec, leftRecursive)
    {
        ((ASTNode) _defineSpec).setParent(this);
    }

    public void addElement(defineSpec _defineSpec)
    {
        base.addElement((ASTNode) _defineSpec);
        ((ASTNode) _defineSpec).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is defineSpecList)) return false;
        if (! base.Equals(o)) return false;
        defineSpecList other = (defineSpecList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            defineSpec element = getdefineSpecAt(i);
            if (! element.Equals(other.getdefineSpecAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getdefineSpecAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getdefineSpecAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getdefineSpecAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getdefineSpecAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getdefineSpecAt(i), o));
        return result;
    }
}
}


