namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 46:  alias_lhs_macro_name ::= MACRO_NAME
 *</b>
 */
public class alias_lhs_macro_name : ASTNodeToken , Ialias_lhs_macro_name
{
    public IToken getMACRO_NAME() { return leftIToken; }

    public alias_lhs_macro_name(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


