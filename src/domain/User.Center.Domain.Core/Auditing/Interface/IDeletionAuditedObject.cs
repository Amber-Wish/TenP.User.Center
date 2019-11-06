using System;

namespace User.Center.Domain.Core.Auditing.Interface
{
    public interface IDeletionAuditedObject:IHasDeletionTime
    {
        Guid? DeleterId { get; set; }
    }

    public interface IDeletionAuditedObject<TUser> : IDeletionAuditedObject
    {
        TUser Deleter { get; set; }
    }

}