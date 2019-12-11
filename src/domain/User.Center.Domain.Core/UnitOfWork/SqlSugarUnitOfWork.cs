using System;
using System.Threading.Tasks;
using SqlSugar;
using User.Center.Infrastructure.Extension.Utils;

namespace User.Center.Domain.Core.UnitOfWork
{
    public class SqlSugarUnitOfWork:ISqlSugarUnitOfWork
    {
        private readonly ISqlSugarClient _sqlSugarClient;

        public SqlSugarUnitOfWork(ISqlSugarClient sqlSugarClient)
        {
            _sqlSugarClient = sqlSugarClient;

            if (ConfigManagerConf.GetValue(new string[] { "AppSettings", "SqlAOP", "Enabled" }).ObjToBool())
            {
                sqlSugarClient.Aop.OnLogExecuting = (sql, pars) => //SQL执行中事件
                {
                    Parallel.For(0, 1, e =>
                    {
                        //MiniProfiler.Current.CustomTiming("SQL：", GetParas(pars) + "【SQL语句】：" + sql);
                        //LogLock.OutSql2Log("SqlLog", new string[] { GetParas(pars), "【SQL语句】：" + sql });

                    });
                };
            }
        }

        private string GetParas(SugarParameter[] pars)
        {
            string key = "【SQL参数】：";
            foreach (var param in pars)
            {
                key += $"{param.ParameterName}:{param.Value}\n";
            }

            return key;
        }


        public ISqlSugarClient GetDbClient()
        {

            return _sqlSugarClient;
        }

        public void BeginTran()
        {
            GetDbClient().Ado.BeginTran();
        }

        public void CommitTran()
        {
            try
            {
                GetDbClient().Ado.CommitTran();
            }
            catch (Exception)
            {
                GetDbClient().Ado.RollbackTran();
                throw;
            }
        }

        public void RollbackTran()
        {
            GetDbClient().Ado.RollbackTran();
        }
    }
}