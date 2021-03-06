using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:20)]
        public string Name { get; set; }
        public List<FlowerCategory> FlowerCategories { get; set; }
    }

}
