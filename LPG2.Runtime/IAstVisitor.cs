
namespace LPG2.Runtime
{
    public interface IAstVisitor
    {
        bool preVisit(IAst element);
        void postVisit(IAst element);
    }

}