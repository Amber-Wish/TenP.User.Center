using User.Center.Domain.Core.Injections;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Repository
{
    /// <summary>
    /// 无状态的 全局单例
    /// </summary>
    public interface IBaseRepository:ISingletonDependency
    {
        
    }

    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {

    }

}