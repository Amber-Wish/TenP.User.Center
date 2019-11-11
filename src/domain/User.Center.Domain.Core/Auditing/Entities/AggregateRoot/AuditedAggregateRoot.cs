﻿using System;
using User.Center.Domain.Core.Auditing.Interface;

namespace User.Center.Domain.Core.Auditing.Entities.AggregateRoot
{
    [Serializable]
    public abstract class AuditedAggregateRoot: CreationAuditedAggregateRoot, IAuditedObject
    {
        public virtual DateTime? LastModificationTime { get; set; }
        public virtual Guid? LastModifierId { get; set; }
    }

    [Serializable]
    public abstract class AuditedAggregateRoot<TKey> : CreationAuditedAggregateRoot<TKey>, IAuditedObject
    {
        public virtual DateTime? LastModificationTime { get; set; }

        public virtual Guid? LastModifierId { get; set; }

        protected AuditedAggregateRoot()
        {

        }

        protected AuditedAggregateRoot(TKey id)
            : base(id)
        {

        }
    }

}