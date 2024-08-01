using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public class Customer : User
    {
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        // navigation property
        public virtual ICollection<Lease> Leases { get; set; }
    }
}
