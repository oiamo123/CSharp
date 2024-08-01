using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    [Table("Slip")]
    public class Slip
    {
        public int ID { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int DockID { get; set; }

        // navigation properties
        public virtual Dock? Dock { get; set; } = null;
        public virtual ICollection<Lease>? Leases { get; set; } = null;

        public bool isAvailable => Leases != null && Leases.Count == 0;
    }
}
