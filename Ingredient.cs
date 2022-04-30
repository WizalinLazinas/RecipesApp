using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp
{
    public record Ingredient
    {
        public string? Name { get; set; }
        public double Amount { get; set; }
        public string? Measurement { get; set; }
        public double Price { get; set; }

    }
}
