namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 20:  LPG_item ::= SOFT_KEYWORDS_KEY$ keywords_segment END_KEY_OPT$
 *</b>
 */
public class SoftKeywordsSeg : ASTNode , ILPG_item
{
    private keywordSpecList _keywords_segment;

    public keywordSpecList getkeywords_segment() { return _keywords_segment; }
    public void setkeywords_segment(keywordSpecList _keywords_segment) { this._keywords_segment = _keywords_segment; }

    public SoftKeywordsSeg(IToken leftIToken, IToken rightIToken,
                           keywordSpecList _keywords_segment)
        :base(leftIToken, rightIToken)

    {
        this._keywords_segment = _keywords_segment;
        ((ASTNode) _keywords_segment).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_keywords_segment);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is SoftKeywordsSeg)) return false;
        if (! base.Equals(o)) return false;
        SoftKeywordsSeg other = (SoftKeywordsSeg) o;
        if (! _keywords_segment.Equals(other._keywords_segment)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_keywords_segment.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


