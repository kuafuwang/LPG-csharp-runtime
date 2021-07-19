namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 59:  macro_name_symbol ::= SYMBOL
 *</b>
 */
public class macro_name_symbol1 : ASTNodeToken , Imacro_name_symbol
{
    public IToken getSYMBOL() { return leftIToken; }

    public macro_name_symbol1(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


