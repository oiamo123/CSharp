using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    // "lightweight" version of Invoice - Data Transfer Object
    public class InvoiceDTO
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }               
        public DateTime InvoiceDate { get; set; }                
        public decimal InvoiceTotal { get; set; }        
    }
}
