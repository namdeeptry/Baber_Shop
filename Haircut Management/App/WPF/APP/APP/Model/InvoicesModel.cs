using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Model
{
    public class InvoicesModel
    {
        public int Id { get; set; }

       
        public int? AppointmentId { get; set; }

       
        public int? TotalPrice { get; set; }

    
        public DateTime? CreatedAt { get; set; }

    }
}
