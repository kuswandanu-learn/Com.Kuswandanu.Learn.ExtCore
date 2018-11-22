using ExtCore.Data.Abstractions;
using ExtCore.ExtensionA.Data.Entities;
using System;
using System.Collections.Generic;

namespace ExtCore.ExtensionA.Data.Abstractions
{
    public interface IPersonRepository : IRepository
    {
        IEnumerable<Person> All();
    }
}
