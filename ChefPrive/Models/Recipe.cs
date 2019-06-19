using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChefPrive.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public bool MarkedAsFavorite { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
