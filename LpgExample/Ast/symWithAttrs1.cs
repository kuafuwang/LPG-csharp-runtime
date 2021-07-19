namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 115:  symWithAttrs ::= SYMBOL optAttrList
 *</b>
 */
public class symWithAttrs1 : ASTNode , IsymWithAttrs
{
    private ASTNodeToken _SYMBOL;
    private symAttrs _optAttrList;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    /**
     * The value returned by <b>getoptAttrList</b> may be <b>null</b>
     */
    public symAttrs getoptAttrList() { return _optAttrList; }
    public void setoptAttrList(symAttrs _optAttrList) { this._optAttrList = _optAttrList; }

    public symWithAttrs1(IToken leftIToken, IToken rightIToken,
                         ASTNodeToken _SYMBOL,
                         symAttrs _optAttrList)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._optAttrList = _optAttrList;
        if (_optAttrList != null) ((ASTNode) _optAttrList).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_SYMBOL);
        list.Add(_optAttrList);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is symWithAttrs1)) return false;
        if (! base.Equals(o)) return false;
        symWithAttrs1 other = (symWithAttrs1) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (_optAttrList == null)
            if (other._optAttrList != null) return false;
            else{}// continue
        else if (! _optAttrList.Equals(other._optAttrList)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_optAttrList == null ? 0 : _optAttrList.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


