namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 123:  start_symbol ::= SYMBOL
 *</b>
 */
public class start_symbol0 : ASTNodeToken , Istart_symbol
{
    public IToken getSYMBOL() { return leftIToken; }

    public start_symbol0(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


