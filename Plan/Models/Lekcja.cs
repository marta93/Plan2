using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Plan.Models
{
    public class Lekcja
    {
        [Key]
        public int ID { set; get; }
        public DateTime GodzinaRozpoczecia { get; set; }
        public virtual Przedmiot Przedmiot { set; get; }
        public string Sala { set; get; }
        public virtual Grupa Grupa { set; get; }

    
    }
}