using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250), Required]
        public string Name { get; set; }
        [MaxLength(250), Required]
        public string Surname { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [MaxLength(250), Required]
        public string UserName { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        public DateTime AddedDate { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
