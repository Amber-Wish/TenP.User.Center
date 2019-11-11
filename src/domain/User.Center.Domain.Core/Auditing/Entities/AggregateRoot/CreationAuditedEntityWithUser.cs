using System;
using User.Center.Domain.Core.Auditing.Interface;

namespace User.Center.Domain.Core.Auditing.Entities.AggregateRoot
{
    [Serializable]
    public abstract class CreationAuditedEntityWithUser<TUser>:
        CreationAuditedEntity,
        ICreationAuditedObject<TUser>
    {
        public virtual TUser Creator { get; set; }
    }

    [Serializable]
    public abstract class CreationAuditedEntityWithUser<TKey, TUser> : CreationAuditedEntity<TKey>, ICreationAuditedObject<TUser>
    {
        public virtual TUser Creator { get; set; }

        protected CreationAuditedEntityWithUser()
        {

        }

        protected CreationAuditedEntityWithUser(TKey id)
            : base(id)
        {

        }
    }

}