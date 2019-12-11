using User.Center.Domain.Core.Injections;

namespace User.Center.Domain.Core.UnitOfWork
{
    public interface IUnitOfWork:IScopedDependency
    {
        void BeginTran();

        void CommitTran();
        void RollbackTran();
    }
}