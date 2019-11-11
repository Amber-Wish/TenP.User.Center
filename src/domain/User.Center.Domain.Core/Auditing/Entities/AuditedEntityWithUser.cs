using System;
using User.Center.Domain.Core.Auditing.Interface;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Auditing.Entities
{
    [Serializable]
    public abstract class AuditedEntityWithUser<TUser> : AuditedEntity, IAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Creator { get; set; }

        public virtual TUser LastModifier { get; set; }
    }

    [Serializable]
    public abstract class AuditedEntityWithUser<TKey, TUser> : AuditedEntity<TKey>, IAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Creator { get; set; }

        public virtual TUser LastModifier { get; set; }

        protected AuditedEntityWithUser()
        {

        }

        protected AuditedEntityWithUser(TKey id)
            : base(id)
        {

        }
    }
}