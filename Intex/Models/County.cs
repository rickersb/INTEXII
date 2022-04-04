using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class County
    {
        [Key]
        [Required]
        public int COUNTY_ID { get; set; }
        [Required]
        public string COUNTY_NAME { get; set; }
    }
}
