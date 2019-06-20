using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public bool MarkedAsFavorite { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public string Title { get; set; }
<<<<<<< HEAD
        
=======
        public string Comment { get; set; }
>>>>>>> c6d81ef9679b5bae39433c49181863ea39a37371

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}

