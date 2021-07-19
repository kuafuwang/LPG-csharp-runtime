namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 83:  keywords_segment ::= keywordSpec
 *<li>Rule 84:  keywords_segment ::= keywords_segment keywordSpec
 *</b>
 */
public class keywordSpecList : AbstractASTNodeList , Ikeywords_segment
{
    public IkeywordSpec getkeywordSpecAt(int i) { return (IkeywordSpec) getElementAt(i); }

    public keywordSpecList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public keywordSpecList(IkeywordSpec _keywordSpec, bool leftRecursive)
        :base((ASTNode) _keywordSpec, leftRecursive)
    {
        ((ASTNode) _keywordSpec).setParent(this);
    }

    public void addElement(IkeywordSpec _keywordSpec)
    {
        base.addElement((ASTNode) _keywordSpec);
        ((ASTNode) _keywordSpec).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is keywordSpecList)) return false;
        if (! base.Equals(o)) return false;
        keywordSpecList other = (keywordSpecList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            IkeywordSpec element = getkeywordSpecAt(i);
            if (! element.Equals(other.getkeywordSpecAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getkeywordSpecAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getkeywordSpecAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getkeywordSpecAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getkeywordSpecAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getkeywordSpecAt(i).accept(v, o));
        return result;
    }
}
}


