namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 66:  globals_segment ::= action_segment
 *<li>Rule 67:  globals_segment ::= globals_segment action_segment
 *<li>Rule 96:  notice_segment ::= action_segment
 *<li>Rule 97:  notice_segment ::= notice_segment action_segment
 *<li>Rule 146:  action_segment_list ::= $Empty
 *<li>Rule 147:  action_segment_list ::= action_segment_list action_segment
 *</b>
 */
public class action_segmentList : AbstractASTNodeList , Iglobals_segment, Inotice_segment, Iaction_segment_list
{
    public action_segment getaction_segmentAt(int i) { return (action_segment) getElementAt(i); }

    public action_segmentList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken, leftRecursive)
    {
    }

    public action_segmentList(action_segment _action_segment, bool leftRecursive)
        :base((ASTNode) _action_segment, leftRecursive)
    {
        ((ASTNode) _action_segment).setParent(this);
    }

    public void addElement(action_segment _action_segment)
    {
        base.addElement((ASTNode) _action_segment);
        ((ASTNode) _action_segment).setParent(this);
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is action_segmentList)) return false;
        if (! base.Equals(o)) return false;
        action_segmentList other = (action_segmentList) o;
        if (size() != other.size()) return false;
        for (int i = 0; i < size(); i++)
        {
            action_segment element = getaction_segmentAt(i);
            if (! element.Equals(other.getaction_segmentAt(i))) return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        for (int i = 0; i < size(); i++)
            hash = hash * 31 + (getaction_segmentAt(i).GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { for (int i = 0; i < size(); i++) v.visit(getaction_segmentAt(i)); }
    public override void accept(ArgumentVisitor v, object o) { for (int i = 0; i < size(); i++) v.visit(getaction_segmentAt(i), o); }
    public override object accept(ResultVisitor v)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getaction_segmentAt(i)));
        return result;
    }
    public override object accept(ResultArgumentVisitor v, object o)
    {
        System.Collections.ArrayList result = new System.Collections.ArrayList();
        for (int i = 0; i < size(); i++)
            result.Add(v.visit(getaction_segmentAt(i), o));
        return result;
    }
}
}


