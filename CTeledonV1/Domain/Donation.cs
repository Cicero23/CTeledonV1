using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTeledonV1.Domain
{
    class Donation : Entity<long>
    {
        private long IdDonor { get; set; }
        private long IdCharityCase { get; set; }
        private int Sum { get; set; }
    }
}
