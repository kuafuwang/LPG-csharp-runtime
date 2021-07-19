namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 111:  rule ::= symWithAttrsList opt_action_segment
 *</b>
 */
public class rule : ASTNode , Irule
{
    private symWithAttrsList _symWithAttrsList;
    private action_segment _opt_action_segment;

    public symWithAttrsList getsymWithAttrsList() { return _symWithAttrsList; }
    public void setsymWithAttrsList(symWithAttrsList _symWithAttrsList) { this._symWithAttrsList = _symWithAttrsList; }
    /**
     * The value returned by <b>getopt_action_segment</b> may be <b>null</b>
     */
    public action_segment getopt_action_segment() { return _opt_action_segment; }
    public void setopt_action_segment(action_segment _opt_action_segment) { this._opt_action_segment = _opt_action_segment; }

    public rule(IToken leftIToken, IToken rightIToken,
                symWithAttrsList _symWithAttrsList,
                action_segment _opt_action_segment)
        :base(leftIToken, rightIToken)

    {
        this._symWithAttrsList = _symWithAttrsList;
        ((ASTNode) _symWithAttrsList).setParent(this);
        this._opt_action_segment = _opt_action_segment;
        if (_opt_action_segment != null) ((ASTNode) _opt_action_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_symWithAttrsList);
        list.Add(_opt_action_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is rule)) return false;
        if (! base.Equals(o)) return false;
        rule other = (rule) o;
        if (! _symWithAttrsList.Equals(other._symWithAttrsList)) return false;
        if (_opt_action_segment == null)
            if (other._opt_action_segment != null) return false;
            else{}// continue
        else if (! _opt_action_segment.Equals(other._opt_action_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_symWithAttrsList.GetHashCode());
        hash = hash * 31 + (_opt_action_segment == null ? 0 : _opt_action_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


