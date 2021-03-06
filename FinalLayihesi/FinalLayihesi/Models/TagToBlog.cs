using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class TagToBlog
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }


        [ForeignKey("Tags")]
        public int TagId { get; set; }
        public Tags Tags { get; set; }
    }
}
