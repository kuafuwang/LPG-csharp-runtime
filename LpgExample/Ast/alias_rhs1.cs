namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 48:  alias_rhs ::= MACRO_NAME
 *</b>
 */
public class alias_rhs1 : ASTNodeToken , Ialias_rhs
{
    public IToken getMACRO_NAME() { return leftIToken; }

    public alias_rhs1(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


