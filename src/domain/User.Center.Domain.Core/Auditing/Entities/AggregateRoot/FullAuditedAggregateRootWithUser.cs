﻿using System;
using User.Center.Domain.Core.Auditing.Interface;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Auditing.Entities.AggregateRoot
{
    [Serializable]
    public abstract class FullAuditedAggregateRootWithUser<TUser>:
        FullAuditedAggregateRoot,
        IFullAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Creator { get; set; }
        public virtual TUser LastModifier { get; set; }
        public virtual TUser Deleter { get; set; }
    }

    [Serializable]
    public abstract class FullAuditedAggregateRootWithUser<TKey, TUser> : FullAuditedAggregateRoot<TKey>, IFullAuditedObject<TUser>
        where TUser : IEntity<long>
    {
        public virtual TUser Deleter { get; set; }

        public TUser Creator { get; set; }

        public TUser LastModifier { get; set; }

        protected FullAuditedAggregateRootWithUser()
        {

        }

        protected FullAuditedAggregateRootWithUser(TKey id)
            : base(id)
        {

        }
    }

}