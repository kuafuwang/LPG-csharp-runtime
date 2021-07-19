namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 102:  ruleNameWithAttributes ::= SYMBOL
 *<li>Rule 103:  ruleNameWithAttributes ::= SYMBOL MACRO_NAME$className
 *<li>Rule 104:  ruleNameWithAttributes ::= SYMBOL MACRO_NAME$className MACRO_NAME$arrayElement
 *</b>
 */
public class RuleName : ASTNode , IruleNameWithAttributes
{
    private ASTNodeToken _SYMBOL;
    private ASTNodeToken _className;
    private ASTNodeToken _arrayElement;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    /**
     * The value returned by <b>getclassName</b> may be <b>null</b>
     */
    public ASTNodeToken getclassName() { return _className; }
    /**
     * The value returned by <b>getarrayElement</b> may be <b>null</b>
     */
    public ASTNodeToken getarrayElement() { return _arrayElement; }

    public RuleName(IToken leftIToken, IToken rightIToken,
                    ASTNodeToken _SYMBOL,
                    ASTNodeToken _className,
                    ASTNodeToken _arrayElement)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._className = _className;
        if (_className != null) ((ASTNode) _className).setParent(this);
        this._arrayElement = _arrayElement;
        if (_arrayElement != null) ((ASTNode) _arrayElement).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        list.Add(_className);
        list.Add(_arrayElement);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is RuleName)) return false;
        if (! base.Equals(o)) return false;
        RuleName other = (RuleName) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (_className == null)
            if (other._className != null) return false;
            else{}// continue
        else if (! _className.Equals(other._className)) return false;
        if (_arrayElement == null)
            if (other._arrayElement != null) return false;
            else{}// continue
        else if (! _arrayElement.Equals(other._arrayElement)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_className == null ? 0 : _className.GetHashCode());
        hash = hash * 31 + (_arrayElement == null ? 0 : _arrayElement.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


