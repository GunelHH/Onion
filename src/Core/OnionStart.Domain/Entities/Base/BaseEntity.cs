﻿using System;
namespace OnionStart.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

    }
}

