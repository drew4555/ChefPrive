using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        public string Original { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client client { get; set; }
    }
}
