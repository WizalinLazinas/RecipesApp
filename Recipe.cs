using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    public record Recipe
    {
        public string? Name { get; set; }
        public List<Ingredient>? Ingredients { get; set; }
        public DateTime CookingTime { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? Instruction { get; set; }
    }
}
