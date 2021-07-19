namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<em>
 *<li>Rule 80:  optMacroName ::= $Empty
 *</em>
 *<p>
 *<b>
 *<li>Rule 81:  optMacroName ::= MACRO_NAME
 *</b>
 */
public class optMacroName : ASTNodeToken , IoptMacroName
{
    public IToken getMACRO_NAME() { return leftIToken; }

    public optMacroName(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


