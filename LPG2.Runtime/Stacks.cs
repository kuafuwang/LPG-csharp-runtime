using System;

namespace LPG2.Runtime
{

    public  class Stacks
    {
        public int STACK_INCREMENT = 1024,
            stateStackTop;
        public int[] stateStack,
            locationStack;

        public object[] parseStack;

        //
        // Given a rule of the form     A ::= x1 x2 ... xn     n > 0
        //
        // the function GETTOKEN(i) yields the symbol xi, if xi is a terminal
        // or ti, if xi is a nonterminal that produced a string of the form
        // xi => ti w.
        //
        public virtual  int getToken(int i)
        {
            return locationStack[stateStackTop + (i - 1)];
        }

        //
        // Given a rule of the form     A ::= x1 x2 ... xn     n > 0
        //
        // The function GETSYM(i) yields the AST subtree associated with symbol
        // xi. NOTE that if xi is a terminal, GETSYM(i) is undefined ! (However,
        // see token_action below.)
        //
        // setSYM1(object ast) is a function that allows us to assign an AST
        // tree to GETSYM(1).
        //
        public object getSym(int i)
        {
            return parseStack[stateStackTop + (i - 1)];
        }

        public void setSym1(object ast)
        {
            parseStack[stateStackTop] = ast;
        }

        //
        // Allocate or reallocate all the stacks. Their sizes should always be the same.
        //
        public void reallocateStacks()
        {
            int old_stack_length = (stateStack == null ? 0 : stateStack.Length),
                stack_length = old_stack_length + STACK_INCREMENT;
            if (stateStack == null)
            {
                stateStack = new int[stack_length];
                locationStack = new int[stack_length];
                parseStack = new object[stack_length];
            }
            else
            {
                Array.Copy(stateStack, 0, stateStack = new int[stack_length], 0, old_stack_length);
                Array.Copy(locationStack, 0, locationStack = new int[stack_length], 0, old_stack_length);
                Array.Copy(parseStack, 0, parseStack = new object[stack_length], 0, old_stack_length);
            }

            return;
        }

        //
        // Allocate or reallocate the state stack only.
        //
        public void reallocateStateStack()
        {
            int old_stack_length = (stateStack == null ? 0 : stateStack.Length),
                stack_length = old_stack_length + STACK_INCREMENT;
            if (stateStack == null)
                stateStack = new int[stack_length];
            else Array.Copy(stateStack, 0, stateStack = new int[stack_length], 0, old_stack_length);
            return;
        }

        //
        // Allocate location and parse stacks using the size of the state stack.
        //
        public void allocateOtherStacks()
        {
            locationStack = new int[stateStack.Length];
            parseStack = new object[stateStack.Length];
            return;
        }
    }
}