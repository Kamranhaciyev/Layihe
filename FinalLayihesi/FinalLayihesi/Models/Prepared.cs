using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class Prepared
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Pretitle { get; set; }
        [MaxLength(250)]
        public string TItle1 { get; set; }
        [MaxLength(250)]
        public string TItle2 { get; set; }
        [MaxLength(3000)]
        public string Description { get; set; }
    }
}
