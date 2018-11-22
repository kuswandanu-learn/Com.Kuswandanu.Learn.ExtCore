using ExtCore.Data.EntityFramework;
using ExtCore.ExtensionA.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExtCore.ExtensionA.Data.EntityFramework.Sqlite
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Person>(etb =>
                {
                    etb.HasKey(e => e.Id);
                    etb.Property(e => e.Id);
                    etb.ToTable("Persons");
                }
            );
        }
    }
}
