using System;
using User.Center.Domain.Core.Auditing.Interface;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Auditing.Entities
{
    [Serializable]
    public abstract class FullAuditedEntityWithUser<TUser> : FullAuditedEntity, IFullAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Deleter { get; set; }

        public TUser Creator { get; set; }

        public TUser LastModifier { get; set; }
    }

    [Serializable]
    public abstract class FullAuditedEntityWithUser<TKey, TUser> : FullAuditedEntity<TKey>, IFullAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Deleter { get; set; }

        public TUser Creator { get; set; }

        public TUser LastModifier { get; set; }

        protected FullAuditedEntityWithUser()
        {

        }

        protected FullAuditedEntityWithUser(TKey id)
            : base(id)
        {

        }
    }
}