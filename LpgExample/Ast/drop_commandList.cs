namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 71:  drop_command_list ::= $Empty
 *<li>Rule 72:  drop_command_list ::= drop_command_list drop_command
 *</b>
 */
public class drop_commandList : AbstractASTNodeList , Idrop_command_list
{
    public Idrop_command getdrop_commandAt(int i) { return (Idrop_command) getElementAt(i); }

    public drop_commandList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public drop_commandList(Idrop_command _drop_command, bool leftRecursive)
        :base((ASTNode) _drop_command, leftRecursive)
    {
        ((ASTNode) _drop_command).setParent(this);
    }

    public void addElement(Idrop_command _drop_command)
    {
        base.addElement((ASTNode) _drop_command);
        ((ASTNode) _drop_command).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is drop_commandList)) return false;
        if (! base.Equals(o)) return false;
        drop_commandList other = (drop_commandList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            Idrop_command element = getdrop_commandAt(i);
            if (! element.Equals(other.getdrop_commandAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getdrop_commandAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) getdrop_commandAt(i).accept(v); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) getdrop_commandAt(i).accept(v, o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getdrop_commandAt(i).accept(v));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(getdrop_commandAt(i).accept(v, o));
        return result;
    }
}
}


