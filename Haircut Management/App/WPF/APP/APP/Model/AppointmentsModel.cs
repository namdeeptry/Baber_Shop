using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Model
{
    public class AppointmentsModel
    {
        public int Id { get; set; }

       
        public int? CustomerId { get; set; }

      
        public int? ServiceId { get; set; }

    
        public int? StaffId { get; set; }

      
        public DateTime? DateTime { get; set; }

      
        public string? Status { get; set; }

    }
}
