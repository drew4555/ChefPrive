using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChefPrive.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ZipCode { get; set; }
        public string FirstName { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        
       
    }
}
