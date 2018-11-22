using ExtCore.Data.Abstractions;
using ExtCore.Data.EntityFramework;
using ExtCore.ExtensionA.Data.Abstractions;
using ExtCore.ExtensionA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtCore.ExtensionA.Data.EntityFramework.Sqlite
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public IEnumerable<Person> All()
        {
            return this.dbSet.OrderBy(p => p.Name);
        }
    }
}
