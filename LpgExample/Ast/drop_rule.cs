namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 79:  drop_rule ::= SYMBOL optMacroName produces ruleList
 *</b>
 */
public class drop_rule : ASTNode , Idrop_rule
{
    private ASTNodeToken _SYMBOL;
    private optMacroName _optMacroName;
    private Iproduces _produces;
    private ruleList _ruleList;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    /**
     * The value returned by <b>getoptMacroName</b> may be <b>null</b>
     */
    public optMacroName getoptMacroName() { return _optMacroName; }
    public void setoptMacroName(optMacroName _optMacroName) { this._optMacroName = _optMacroName; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public ruleList getruleList() { return _ruleList; }
    public void setruleList(ruleList _ruleList) { this._ruleList = _ruleList; }

    public drop_rule(IToken leftIToken, IToken rightIToken,
                     ASTNodeToken _SYMBOL,
                     optMacroName _optMacroName,
                     Iproduces _produces,
                     ruleList _ruleList)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._optMacroName = _optMacroName;
        if (_optMacroName != null) ((ASTNode) _optMacroName).setParent(this);
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
        list.Add(_SYMBOL);
        list.Add(_optMacroName);
        list.Add(_produces);
        list.Add(_ruleList);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is drop_rule)) return false;
        if (! base.Equals(o)) return false;
        drop_rule other = (drop_rule) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (_optMacroName == null)
            if (other._optMacroName != null) return false;
            else{}// continue
        else if (! _optMacroName.Equals(other._optMacroName)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _ruleList.Equals(other._ruleList)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_optMacroName == null ? 0 : _optMacroName.GetHashCode());
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


