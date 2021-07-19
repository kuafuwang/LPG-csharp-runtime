namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 101:  nonTerm ::= ruleNameWithAttributes produces ruleList
 *</b>
 */
public class nonTerm : ASTNode , InonTerm
{
    private RuleName _ruleNameWithAttributes;
    private Iproduces _produces;
    private ruleList _ruleList;

    public RuleName getruleNameWithAttributes() { return _ruleNameWithAttributes; }
    public void setruleNameWithAttributes(RuleName _ruleNameWithAttributes) { this._ruleNameWithAttributes = _ruleNameWithAttributes; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public ruleList getruleList() { return _ruleList; }
    public void setruleList(ruleList _ruleList) { this._ruleList = _ruleList; }

    public nonTerm(IToken leftIToken, IToken rightIToken,
                   RuleName _ruleNameWithAttributes,
                   Iproduces _produces,
                   ruleList _ruleList)
        :base(leftIToken, rightIToken)

    {
        this._ruleNameWithAttributes = _ruleNameWithAttributes;
        ((ASTNode) _ruleNameWithAttributes).setParent(this);
        this._produces = _produces;
        ((ASTNode) _produces).setParent(this);
        this._ruleList = _ruleList;
        ((ASTNode) _ruleList).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_ruleNameWithAttributes);
        list.Add(_produces);
        list.Add(_ruleList);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is nonTerm)) return false;
        if (! base.Equals(o)) return false;
        nonTerm other = (nonTerm) o;
        if (! _ruleNameWithAttributes.Equals(other._ruleNameWithAttributes)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _ruleList.Equals(other._ruleList)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_ruleNameWithAttributes.GetHashCode());
        hash = hash * 31 + (_produces.GetHashCode());
        hash = hash * 31 + (_ruleList.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


