using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool isResort { get; set; }

        public Destination destination { get; set; }
    }
}
