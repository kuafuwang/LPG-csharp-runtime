namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 58:  macro_name_symbol ::= MACRO_NAME
 *</b>
 */
public class macro_name_symbol0 : ASTNodeToken , Imacro_name_symbol
{
    public IToken getMACRO_NAME() { return leftIToken; }

    public macro_name_symbol0(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


