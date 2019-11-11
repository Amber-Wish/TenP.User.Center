﻿using System;
using User.Center.Domain.Core.Auditing.Interface;
using User.Center.Domain.Core.Models;

namespace User.Center.Domain.Core.Auditing.Entities
{
    [Serializable]
    public abstract class CreationAuditedEntity:Entity,ICreationAuditedObject
    {
        public virtual DateTime CreationTime { get; set; }
        public virtual Guid CreatorId { get; set; }
    }

    [Serializable]
    public abstract class CreationAuditedEntity<TKey>:Entity<TKey>,ICreationAuditedObject
    {
        public virtual DateTime CreationTime { get; set; }
        public virtual Guid CreatorId { get; set; }

        protected CreationAuditedEntity()
        { }

        protected CreationAuditedEntity(TKey id)
            : base(id)
        {

        }

    }
}