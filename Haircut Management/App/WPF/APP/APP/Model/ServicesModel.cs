﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Model
{
   public class ServicesModel
    {
        public int Id { get; set; }

     
        public string? Name { get; set; }

        public int? Price { get; set; }

     
        public int? Duration { get; set; }

    }
}
