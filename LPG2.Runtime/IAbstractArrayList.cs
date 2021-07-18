using System.Collections;

namespace LPG2.Runtime
{

    public interface IAbstractArrayList<T > where T:  IAst
    {
    public int size();
    public T getElementAt(int i);
    public ArrayList getList();
    public bool add(T elt);
    public ArrayList getAllChildren();
    }
}