namespace LpgExample.Ast
{

using LpgExample;

using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 1:  LPG ::= options_segment LPG_INPUT
 *</b>
 */
public class LPG : ASTNode , ILPG
{
    private LPGParser environment;
    public LPGParser getEnvironment() { return environment; }

    private option_specList _options_segment;
    private LPG_itemList _LPG_INPUT;

    public option_specList getoptions_segment() { return _options_segment; }
    public void setoptions_segment(option_specList _options_segment) { this._options_segment = _options_segment; }
    public LPG_itemList getLPG_INPUT() { return _LPG_INPUT; }
    public void setLPG_INPUT(LPG_itemList _LPG_INPUT) { this._LPG_INPUT = _LPG_INPUT; }

    public LPG(LPGParser environment, IToken leftIToken, IToken rightIToken,
               option_specList _options_segment,
               LPG_itemList _LPG_INPUT)
        :base(leftIToken, rightIToken)

    {
        this.environment = environment;
        this._options_segment = _options_segment;
        ((ASTNode) _options_segment).setParent(this);
        this._LPG_INPUT = _LPG_INPUT;
        ((ASTNode) _LPG_INPUT).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_options_segment);
        list.Add(_LPG_INPUT);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is LPG)) return false;
        if (! base.Equals(o)) return false;
        LPG other = (LPG) o;
        if (! _options_segment.Equals(other._options_segment)) return false;
        if (! _LPG_INPUT.Equals(other._LPG_INPUT)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_options_segment.GetHashCode());
        hash = hash * 31 + (_LPG_INPUT.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}

    //#line 46 "LPGParser.g


 }


