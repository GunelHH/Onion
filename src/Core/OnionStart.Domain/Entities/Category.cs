using System;
using OnionStart.Domain.Entities.Base;

namespace OnionStart.Domain.Entities
{
    public class Category:BaseEntity
    {
        [Serializable]
        public string Name { get; set; }
        
    }
}

