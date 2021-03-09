using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTeledonV1.Domain;

namespace CTeledonV1.Repository
{
    interface IRepoDonation: IRepository<long,Donation>
    {
        IEnumerable<Donation> FindByCharityCase(long idCharityCase);
        int TotalForCharityCase(long idCharityCase);
    }
}
