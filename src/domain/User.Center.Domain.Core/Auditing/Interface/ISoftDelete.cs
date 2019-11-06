namespace User.Center.Domain.Core.Auditing.Interface
{
    /// <summary>
    /// 标记软删除实体
    /// </summary>
    public interface ISoftDelete
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        bool IsDeleted { get; set; }
    }
}