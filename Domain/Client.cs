
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Domain.ApplicationDbContext;

namespace Domain
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public int ZipCode { get; set; }
        public string FirstName { get; set; }
        public int FamilySize { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        [NotMapped]
        public List<string> Favorites { get; set; }
        [NotMapped]
        public List<string> WeeklyMealPlan { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
