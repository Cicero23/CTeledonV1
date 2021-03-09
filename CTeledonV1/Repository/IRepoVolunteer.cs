using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTeledonV1.Domain;

namespace CTeledonV1.Repository
{
    interface IRepoVolunteer: IRepository<long,Volunteer>
    {
        bool Login(string username, string password);
    }
}
