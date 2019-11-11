﻿using System;
using User.Center.Domain.Core.Auditing.Interface;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Auditing.Entities.AggregateRoot
{
    [Serializable]
    public abstract class CreationAuditedAggregateRoot:Models.AggregateRoot,ICreationAuditedObject
    {
        public DateTime CreationTime { get; set; }
        public Guid CreatorId { get; set; }
    }

    [Serializable]
    public abstract class CreationAuditedAggregateRoot<TKey> : AggregateRoot<TKey>, ICreationAuditedObject
    {
        public virtual DateTime CreationTime { get; set; }

        public virtual Guid CreatorId { get; set; }

        protected CreationAuditedAggregateRoot()
        {

        }

        protected CreationAuditedAggregateRoot(TKey id)
            : base(id)
        {

        }
    }

}