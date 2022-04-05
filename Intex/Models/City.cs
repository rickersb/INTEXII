using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class City
    {
        [Key]
        [Required]
        public int CITY_ID { get; set; }
        [Required]
        public string CITY { get; set; }

    }
}
