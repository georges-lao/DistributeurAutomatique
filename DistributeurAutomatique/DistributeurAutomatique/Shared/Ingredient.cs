using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurAutomatique.Shared
{
    /// <summary>
    /// Beverage ingredients Class
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Ingredients ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ingredient Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ingredient Price
        /// </summary>
        public float Price { get; set; }
    }
}
