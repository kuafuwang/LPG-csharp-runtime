namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 27:  options_segment ::= $Empty
 *<li>Rule 28:  options_segment ::= options_segment option_spec
 *</b>
 */
public class option_specList : AbstractASTNodeList , Ioptions_segment
{
    public option_spec getoption_specAt(int i) { return (option_spec) getElementAt(i); }

    public option_specList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public option_specList(option_spec _option_spec, bool leftRecursive)
        :base((ASTNode) _option_spec, leftRecursive)
    {
        ((ASTNode) _option_spec).setParent(this);
    }

    public void addElement(option_spec _option_spec)
    {
        base.addElement((ASTNode) _option_spec);
        ((ASTNode) _option_spec).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is option_specList)) return false;
        if (! base.Equals(o)) return false;
        option_specList other = (option_specList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            option_spec element = getoption_specAt(i);
            if (! element.Equals(other.getoption_specAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getoption_specAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getoption_specAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getoption_specAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getoption_specAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getoption_specAt(i), o));
        return result;
    }
}
}


