using ExtCore.Data.Entities.Abstractions;
using System;

namespace ExtCore.ExtensionA.Data.Entities
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
