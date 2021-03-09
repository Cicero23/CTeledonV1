using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTeledonV1.Domain
{
    class Donor:Entity<long>
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private string Phone { get; set; }
    }
}
