using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTeledonV1.Domain;

namespace CTeledonV1.Repository
{
    interface IRepository <ID, E> where E:Entity<ID>
    {
        E FindOne(ID id);

        IEnumerable<E> FindAll();

        E Save(E entity);

        E Delete(ID id);

        E Update(E entity);

    }
}
