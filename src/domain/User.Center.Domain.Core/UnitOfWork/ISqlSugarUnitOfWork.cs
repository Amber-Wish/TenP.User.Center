using SqlSugar;

namespace User.Center.Domain.Core.UnitOfWork
{
    public interface ISqlSugarUnitOfWork:IUnitOfWork
    {
        ISqlSugarClient GetDbClient();
    }
}