namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 30:  option_list ::= option
 *<li>Rule 31:  option_list ::= option_list ,$ option
 *</b>
 */
public class optionList : AbstractASTNodeList , Ioption_list
{
    public option getoptionAt(int i) { return (option) getElementAt(i); }

    public optionList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public optionList(option _option, bool leftRecursive)
        :base((ASTNode) _option, leftRecursive)
    {
        ((ASTNode) _option).setParent(this);
    }

    public void addElement(option _option)
    {
        base.addElement((ASTNode) _option);
        ((ASTNode) _option).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is optionList)) return false;
        if (! base.Equals(o)) return false;
        optionList other = (optionList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            option element = getoptionAt(i);
            if (! element.Equals(other.getoptionAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getoptionAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getoptionAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getoptionAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getoptionAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getoptionAt(i), o));
        return result;
    }
}
}


