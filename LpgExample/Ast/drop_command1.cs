namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 74:  drop_command ::= DROPRULES_KEY drop_rules
 *</b>
 */
public class drop_command1 : ASTNode , Idrop_command
{
    private ASTNodeToken _DROPRULES_KEY;
    private drop_ruleList _drop_rules;

    public ASTNodeToken getDROPRULES_KEY() { return _DROPRULES_KEY; }
    public void setDROPRULES_KEY(ASTNodeToken _DROPRULES_KEY) { this._DROPRULES_KEY = _DROPRULES_KEY; }
    public drop_ruleList getdrop_rules() { return _drop_rules; }
    public void setdrop_rules(drop_ruleList _drop_rules) { this._drop_rules = _drop_rules; }

    public drop_command1(IToken leftIToken, IToken rightIToken,
                         ASTNodeToken _DROPRULES_KEY,
                         drop_ruleList _drop_rules)
        :base(leftIToken, rightIToken)

    {
        this._DROPRULES_KEY = _DROPRULES_KEY;
        ((ASTNode) _DROPRULES_KEY).setParent(this);
        this._drop_rules = _drop_rules;
        ((ASTNode) _drop_rules).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_DROPRULES_KEY);
        list.Add(_drop_rules);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is drop_command1)) return false;
        if (! base.Equals(o)) return false;
        drop_command1 other = (drop_command1) o;
        if (! _DROPRULES_KEY.Equals(other._DROPRULES_KEY)) return false;
        if (! _drop_rules.Equals(other._drop_rules)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_DROPRULES_KEY.GetHashCode());
        hash = hash * 31 + (_drop_rules.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


