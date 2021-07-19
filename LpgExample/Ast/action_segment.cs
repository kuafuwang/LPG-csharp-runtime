namespace LpgExample.Ast
{

using LpgExample;

using LPG2.Runtime;
using System;



 
/**
 *<b>
 *<li>Rule 120:  action_segment ::= BLOCK
 *</b>
 */
public class action_segment : ASTNodeToken , Iaction_segment
{
    private LPGParser environment;
    public LPGParser getEnvironment() { return environment; }

    public IToken getBLOCK() { return leftIToken; }

    public action_segment(LPGParser environment, IToken token)        :base(token)
    {
        this.environment = environment;
        initialize();
    }

    public override void accept(Visitor v) { v.visit(this); }
    public override  void accept(ArgumentVisitor v, object o) { v.visit(this, o); }
    public override object accept(ResultVisitor v) { return v.visit(this); }
    public override  object accept(ResultArgumentVisitor v, object o) { return v.visit(this, o); }
}

    //#line 223 "LPGParser.g

}


