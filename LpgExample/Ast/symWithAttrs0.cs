namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 114:  symWithAttrs ::= EMPTY_KEY
 *</b>
 */
public class symWithAttrs0 : ASTNodeToken , IsymWithAttrs
{
    public IToken getEMPTY_KEY() { return leftIToken; }

    public symWithAttrs0(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


