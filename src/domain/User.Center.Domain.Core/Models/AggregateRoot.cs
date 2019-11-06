using System;

namespace User.Center.Domain.Core.Models
{
    [Serializable]
    public abstract class AggregateRoot:Entity,IAggregateRoot
    {
    }

    [Serializable]
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
    {

    }


}