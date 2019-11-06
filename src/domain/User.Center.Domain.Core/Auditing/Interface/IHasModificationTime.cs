using System;

namespace User.Center.Domain.Core.Auditing.Interface
{
    /// <summary>
    /// 将最后修改时间增加到实体中的接口
    /// </summary>
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}