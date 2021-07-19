namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
/**
 *<em>
 *<li>Rule 144:  END_KEY_OPT ::= $Empty
 *</em>
 *<p>
 *<b>
 *<li>Rule 145:  END_KEY_OPT ::= END_KEY
 *</b>
 */
public class END_KEY_OPT : ASTNodeToken , IEND_KEY_OPT
{
    public IToken getEND_KEY() { return leftIToken; }

    public END_KEY_OPT(IToken token):base(token) {  initialize(); }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}
}


