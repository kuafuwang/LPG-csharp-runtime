namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 130:  terminal_symbol ::= SYMBOL
 *</b>
 */
public class terminal_symbol0 : ASTNodeToken , Iterminal_symbol
{
    public IToken getSYMBOL() { return leftIToken; }

    public terminal_symbol0(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


