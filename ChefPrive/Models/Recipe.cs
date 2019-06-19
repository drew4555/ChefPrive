using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChefPrive.Models
{
    public class Recipe  //history
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
<<<<<<< HEAD:Models/Recipe.cs
        public bool Favorite { get; set; }
=======
        public bool MarkedAsFavorite { get; set; }

>>>>>>> bb84592aaa718b0396524f7f7e6173d4a8a6736d:ChefPrive/Models/Recipe.cs
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
