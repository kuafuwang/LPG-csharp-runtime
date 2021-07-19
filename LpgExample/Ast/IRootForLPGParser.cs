namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
    public interface IRootForLPGParser
    {
        public IToken getLeftIToken();
        public IToken getRightIToken();

        void accept(Visitor v);
        void accept(ArgumentVisitor v, object o);
        object accept(ResultVisitor v);
        object accept(ResultArgumentVisitor v, object o);
    }

    }

