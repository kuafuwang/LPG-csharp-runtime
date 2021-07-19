namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 127:  terminal ::= terminal_symbol optTerminalAlias
 *</b>
 */
public class terminal : ASTNode , Iterminal
{
    private Iterminal_symbol _terminal_symbol;
    private optTerminalAlias _optTerminalAlias;

    public Iterminal_symbol getterminal_symbol() { return _terminal_symbol; }
    public void setterminal_symbol(Iterminal_symbol _terminal_symbol) { this._terminal_symbol = _terminal_symbol; }
    /**
     * The value returned by <b>getoptTerminalAlias</b> may be <b>null</b>
     */
    public optTerminalAlias getoptTerminalAlias() { return _optTerminalAlias; }
    public void setoptTerminalAlias(optTerminalAlias _optTerminalAlias) { this._optTerminalAlias = _optTerminalAlias; }

    public terminal(IToken leftIToken, IToken rightIToken,
                    Iterminal_symbol _terminal_symbol,
                    optTerminalAlias _optTerminalAlias)
        :base(leftIToken, rightIToken)

    {
        this._terminal_symbol = _terminal_symbol;
        ((ASTNode) _terminal_symbol).setParent(this);
        this._optTerminalAlias = _optTerminalAlias;
        if (_optTerminalAlias != null) ((ASTNode) _optTerminalAlias).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_terminal_symbol);
        list.Add(_optTerminalAlias);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is terminal)) return false;
        if (! base.Equals(o)) return false;
        terminal other = (terminal) o;
        if (! _terminal_symbol.Equals(other._terminal_symbol)) return false;
        if (_optTerminalAlias == null)
            if (other._optTerminalAlias != null) return false;
            else{}// continue
        else if (! _optTerminalAlias.Equals(other._optTerminalAlias)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_terminal_symbol.GetHashCode());
        hash = hash * 31 + (_optTerminalAlias == null ? 0 : _optTerminalAlias.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


