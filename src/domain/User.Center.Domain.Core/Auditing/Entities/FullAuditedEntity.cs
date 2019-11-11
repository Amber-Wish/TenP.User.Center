using System;
using User.Center.Domain.Core.Auditing.Interface;

namespace User.Center.Domain.Core.Auditing.Entities
{
    [Serializable]
    public abstract class FullAuditedEntity:AuditedEntity,IFullAuditedObject
    {
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        public virtual Guid? DeleterId { get; set; }
    }

    [Serializable]
    public abstract class FullAuditedEntity<TKey> : AuditedEntity<TKey>, IFullAuditedObject
    {
        public virtual bool IsDeleted { get; set; }

        public virtual Guid? DeleterId { get; set; }

        public virtual DateTime? DeletionTime { get; set; }

        protected FullAuditedEntity()
        {

        }

        protected FullAuditedEntity(TKey id)
            : base(id)
        {

        }
    }

}