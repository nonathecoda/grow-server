﻿namespace Grow.Data.Entities
{
    public class Partner : BaseEntity
    {
        public string Description { get; set; }

        public virtual Image Image { get; set; }

        public virtual Contest Contest { get; set; }
    }
}