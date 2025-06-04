using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Model
{
    public class CustomersModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? Phone { get; set; }
        public DateOnly? BirthDate { get; set; }       
        public DateTime? CreateAt { get; set; }

    }
}
