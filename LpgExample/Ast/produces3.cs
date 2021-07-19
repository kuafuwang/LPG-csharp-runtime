namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 110:  produces ::= ->?
 *</b>
 */
public class produces3 : ASTNodeToken , Iproduces
{
    public IToken getPRIORITY_ARROW() { return leftIToken; }

    public produces3(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


