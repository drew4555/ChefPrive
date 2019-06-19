
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static ChefPrive.Data.ApplicationDbContext;

namespace ChefPrive.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public int ZipCode { get; set; }
        public string FirstName { get; set; }
        public int FamilySize { get; set; }
        public bool Vegetarian { get; set; }
<<<<<<< HEAD:ChefPrive/Models/Client.cs
        public bool Vegan { get; set; } 
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

=======
        public bool Vegan { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
>>>>>>> 2b4031a491f41c17ff533f5a62b59672a79287d0:ChefPrive/Client.cs
    }
}
