namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 98:  rules_segment ::= action_segment_list nonTermList
 *</b>
 */
public class rules_segment : ASTNode , Irules_segment
{
    private action_segmentList _action_segment_list;
    private nonTermList _nonTermList;

    public action_segmentList getaction_segment_list() { return _action_segment_list; }
    public void setaction_segment_list(action_segmentList _action_segment_list) { this._action_segment_list = _action_segment_list; }
    public nonTermList getnonTermList() { return _nonTermList; }
    public void setnonTermList(nonTermList _nonTermList) { this._nonTermList = _nonTermList; }

    public rules_segment(IToken leftIToken, IToken rightIToken,
                         action_segmentList _action_segment_list,
                         nonTermList _nonTermList)
        :base(leftIToken, rightIToken)

    {
        this._action_segment_list = _action_segment_list;
        ((ASTNode) _action_segment_list).setParent(this);
        this._nonTermList = _nonTermList;
        ((ASTNode) _nonTermList).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_action_segment_list);
        list.Add(_nonTermList);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is rules_segment)) return false;
        if (! base.Equals(o)) return false;
        rules_segment other = (rules_segment) o;
        if (! _action_segment_list.Equals(other._action_segment_list)) return false;
        if (! _nonTermList.Equals(other._nonTermList)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_action_segment_list.GetHashCode());
        hash = hash * 31 + (_nonTermList.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


