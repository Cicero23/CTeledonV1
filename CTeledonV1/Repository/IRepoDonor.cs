using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTeledonV1.Domain;

namespace CTeledonV1.Repository
{
    interface IRepoDonor: IRepository<long,Donor>
    {
        Donor FindByName(String name);
    }
}
