using System;
using User.Center.Domain.Core.Auditing.Interface;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Auditing.Entities.AggregateRoot
{
    [Serializable]
    public abstract class AuditedAggregateRootWithUser<TUser>:
        AuditedAggregateRoot,
        IAuditedObject<TUser> 
        where TUser:IEntity<long>
    {
        public virtual TUser Creator { get; set; }
        public virtual TUser LastModifier { get; set; }
    }

    [Serializable]
    public abstract class AuditedAggregateRootWithUser<TKey, TUser> : AuditedAggregateRoot<TKey>, IAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Creator { get; set; }

        public virtual TUser LastModifier { get; set; }

        protected AuditedAggregateRootWithUser()
        {

        }

        protected AuditedAggregateRootWithUser(TKey id)
            : base(id)
        {

        }
    }

}