namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 135:  type_declarations ::= SYMBOL produces barSymbolList opt_action_segment
 *</b>
 */
public class type_declarations : ASTNode , Itype_declarations
{
    private ASTNodeToken _SYMBOL;
    private Iproduces _produces;
    private SYMBOLList _barSymbolList;
    private action_segment _opt_action_segment;

    public ASTNodeToken getSYMBOL() { return _SYMBOL; }
    public void setSYMBOL(ASTNodeToken _SYMBOL) { this._SYMBOL = _SYMBOL; }
    public Iproduces getproduces() { return _produces; }
    public void setproduces(Iproduces _produces) { this._produces = _produces; }
    public SYMBOLList getbarSymbolList() { return _barSymbolList; }
    public void setbarSymbolList(SYMBOLList _barSymbolList) { this._barSymbolList = _barSymbolList; }
    /**
     * The value returned by <b>getopt_action_segment</b> may be <b>null</b>
     */
    public action_segment getopt_action_segment() { return _opt_action_segment; }
    public void setopt_action_segment(action_segment _opt_action_segment) { this._opt_action_segment = _opt_action_segment; }

    public type_declarations(IToken leftIToken, IToken rightIToken,
                             ASTNodeToken _SYMBOL,
                             Iproduces _produces,
                             SYMBOLList _barSymbolList,
                             action_segment _opt_action_segment)
        :base(leftIToken, rightIToken)

    {
        this._SYMBOL = _SYMBOL;
        ((ASTNode) _SYMBOL).setParent(this);
        this._produces = _produces;
        ((ASTNode) _produces).setParent(this);
        this._barSymbolList = _barSymbolList;
        ((ASTNode) _barSymbolList).setParent(this);
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
        list.Add(_SYMBOL);
        list.Add(_produces);
        list.Add(_barSymbolList);
        list.Add(_opt_action_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is type_declarations)) return false;
        if (! base.Equals(o)) return false;
        type_declarations other = (type_declarations) o;
        if (! _SYMBOL.Equals(other._SYMBOL)) return false;
        if (! _produces.Equals(other._produces)) return false;
        if (! _barSymbolList.Equals(other._barSymbolList)) return false;
        if (_opt_action_segment == null)
            if (other._opt_action_segment != null) return false;
            else{}// continue
        else if (! _opt_action_segment.Equals(other._opt_action_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_SYMBOL.GetHashCode());
        hash = hash * 31 + (_produces.GetHashCode());
        hash = hash * 31 + (_barSymbolList.GetHashCode());
        hash = hash * 31 + (_opt_action_segment == null ? 0 : _opt_action_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


