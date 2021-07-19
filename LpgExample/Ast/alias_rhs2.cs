namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 49:  alias_rhs ::= ERROR_KEY
 *</b>
 */
public class alias_rhs2 : ASTNodeToken , Ialias_rhs
{
    public IToken getERROR_KEY() { return leftIToken; }

    public alias_rhs2(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


