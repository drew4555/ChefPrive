using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChefPrive.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

    }
}
