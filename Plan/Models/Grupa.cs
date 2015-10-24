using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Plan.Models
{
    public class Grupa
    {
        [Key]
        public int ID { set; get; }
        public int NumerGrupy {get;set;}

    }
}