
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
<<<<<<< HEAD:Models/Client.cs
        public bool Vegan { get; set; }  //shouldn't be able to choose both
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }


=======
        public bool Vegan { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
>>>>>>> bb84592aaa718b0396524f7f7e6173d4a8a6736d:ChefPrive/Models/Client.cs
    }
}
