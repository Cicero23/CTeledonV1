using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTeledonV1.Domain
{
    class Volunteer: Entity<long>
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private string Name { get; set; }


    }
}
