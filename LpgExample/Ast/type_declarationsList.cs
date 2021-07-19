namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 133:  types_segment ::= type_declarations
 *<li>Rule 134:  types_segment ::= types_segment type_declarations
 *</b>
 */
public class type_declarationsList : AbstractASTNodeList , Itypes_segment
{
    public type_declarations gettype_declarationsAt(int i) { return (type_declarations) getElementAt(i); }

    public type_declarationsList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public type_declarationsList(type_declarations _type_declarations, bool leftRecursive)
        :base((ASTNode) _type_declarations, leftRecursive)
    {
        ((ASTNode) _type_declarations).setParent(this);
    }

    public void addElement(type_declarations _type_declarations)
    {
        base.addElement((ASTNode) _type_declarations);
        ((ASTNode) _type_declarations).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is type_declarationsList)) return false;
        if (! base.Equals(o)) return false;
        type_declarationsList other = (type_declarationsList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            type_declarations element = gettype_declarationsAt(i);
            if (! element.Equals(other.gettype_declarationsAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (gettype_declarationsAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(gettype_declarationsAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(gettype_declarationsAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(gettype_declarationsAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(gettype_declarationsAt(i), o));
        return result;
    }
}
}


