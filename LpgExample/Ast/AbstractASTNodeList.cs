namespace LpgExample.Ast
{


using LPG2.Runtime;
using System;



 
public abstract class AbstractASTNodeList : ASTNode , IAbstractArrayList<ASTNode>
{
    private bool leftRecursive;
    private ArrayListEx<ASTNode> list=new ArrayListEx<ASTNode>();
    public int size() { return list.Count; }
    public  System.Collections.ArrayList getList() { return list; }
    public ASTNode getElementAt(int i) { return (ASTNode) list.get(leftRecursive ? i : list.Count - 1 - i); }
    public System.Collections.ArrayList getArrayList()
    {
        if (! leftRecursive) // reverse the list 
        {
            for (int i = 0, n = list.Count - 1; i < n; i++, n--)
            {
                dynamic ith = list.get(i),
                       nth = list.get(n);
                list.set(i, nth);
                list.set(n, ith);
            }
            leftRecursive = true;
        }
        return list;
    }
    /**
     * @deprecated replaced by {@link #addElement()}
     *
     */
    public bool add(ASTNode element)
    {
        addElement(element);
        return true;
    }

    public void addElement(ASTNode element)
    {
        list.Add(element);
        if (leftRecursive)
             rightIToken = element.getRightIToken();
        else leftIToken = element.getLeftIToken();
    }

    public AbstractASTNodeList(IToken leftIToken, IToken rightIToken, bool leftRecursive):base(leftIToken, rightIToken)
    {
        this.leftRecursive = leftRecursive;
       
    }

    public AbstractASTNodeList(ASTNode element, bool leftRecursive)
        :this(element.getLeftIToken(), element.getRightIToken(), leftRecursive)
    {
        list.Add(element);
    }

    /**
     * Make a copy of the list and return it. Note that we obtain the local list by
     * invoking getArrayList so as to make sure that the list we return is in proper order.
     */
    public override System.Collections.ArrayList getAllChildren()
    {
        return (System.Collections.ArrayList) getArrayList().Clone();
    }

}

}

