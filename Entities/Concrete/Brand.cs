﻿
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => "Marka";
    }
}
