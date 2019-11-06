using System;

namespace User.Center.Domain.Core.Auditing.Interface
{
    public interface IHasDeletionTime:ISoftDelete
    {
        /// <summary>
        /// 删除时间
        /// </summary>
        DateTime? DeletionTime { get; set; }
    }
}