using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plan.Models
{
    public class Przedmiot
    {
        [Key]
        public int ID { set; get; }
        public String Nazwa { get; set; }
        public String Prowadzacy { get; set; }

    }
}