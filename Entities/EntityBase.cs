using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCC_Marina.Entities
{
    public abstract class EntityBase<TIdentifier> : IEntity<TIdentifier>
    {
        public TIdentifier Id { get; set; }
    }
}