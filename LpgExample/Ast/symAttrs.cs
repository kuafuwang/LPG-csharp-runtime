namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 116:  optAttrList ::= $Empty
 *<li>Rule 117:  optAttrList ::= MACRO_NAME
 *</b>
 */
public class symAttrs : ASTNode , IoptAttrList
{
    private ASTNodeToken _MACRO_NAME;

    /**
     * The value returned by <b>getMACRO_NAME</b> may be <b>null</b>
     */
    public ASTNodeToken getMACRO_NAME() { return _MACRO_NAME; }

    public symAttrs(IToken leftIToken, IToken rightIToken,
                    ASTNodeToken _MACRO_NAME)
        :base(leftIToken, rightIToken)

    {
        this._MACRO_NAME = _MACRO_NAME;
        if (_MACRO_NAME != null) ((ASTNode) _MACRO_NAME).setParent(this);
        initialize();
    }

    /**
     * A list of all children of this node, including the null ones.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        list.Add(_MACRO_NAME);
        return list;
    }

    public override bool Equals(object o)
    {
        if (o == this) return true;
        if (! (o is symAttrs)) return false;
        if (! base.Equals(o)) return false;
        symAttrs other = (symAttrs) o;
        if (_MACRO_NAME == null)
            if (other._MACRO_NAME != null) return false;
            else{}// continue
        else if (! _MACRO_NAME.Equals(other._MACRO_NAME)) return false;
        return true;
    }

    public override int GetHashCode()
    {
        int hash = base.GetHashCode();
        hash = hash * 31 + (_MACRO_NAME == null ? 0 : _MACRO_NAME.GetHashCode());
        return hash;
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


