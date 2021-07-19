namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 38:  alias_segment ::= aliasSpec
 *<li>Rule 39:  alias_segment ::= alias_segment aliasSpec
 *</b>
 */
public class aliasSpecList : AbstractASTNodeList , Ialias_segment
{
    public IaliasSpec getaliasSpecAt(int i) { return (IaliasSpec) getElementAt(i); }

    public aliasSpecList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public aliasSpecList(IaliasSpec _aliasSpec, bool leftRecursive)
        :base((ASTNode) _aliasSpec, leftRecursive)
    {
        ((ASTNode) _aliasSpec).setParent(this);
    }

    public void addElement(IaliasSpec _aliasSpec)
    {
        base.addElement((ASTNode) _aliasSpec);
        ((ASTNode) _aliasSpec).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is aliasSpecList)) return false;
        if (! base.Equals(o)) return false;
        aliasSpecList other = (aliasSpecList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            IaliasSpec element = getaliasSpecAt(i);
            if (! element.Equals(other.getaliasSpecAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getaliasSpecAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getaliasSpecAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getaliasSpecAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getaliasSpecAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getaliasSpecAt(i).accept(v, o));
        return result;
    }
}
}


