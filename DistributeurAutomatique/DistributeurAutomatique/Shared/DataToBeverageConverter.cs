using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurAutomatique.Shared
{
    /// <summary>
    /// tool classe convert data to beverage object
    /// </summary>
    public static class DataToBeverageConverter
    {
        /// <summary>
        /// convert csv string to Beverage object
        /// </summary>
        /// <param name="input">csv string</param>
        /// <returns>Beverage</returns>
        public static Beverage GetBeverage(string beverage, List<string> recipes, List<Ingredient> ingredients) 
        {
            var result = new Beverage();
            string[] t = beverage.Split(';');
            result.Id = int.Parse(t[0]);
            result.Name = t[1];
            result.RecipeId = int.Parse(t[2]);

            var r = recipes[result.RecipeId - 1].Split(';');
            float price = 0;
            for (int i = 1; i < r.Length; i++)
            {
                price += ingredients[int.Parse(r[i])-1].Price;
            }
            result.Price = price.ToString();

            return result;
        }

        /// <summary>
        /// convert csv string to Ingredient object
        /// </summary>
        /// <param name="ingredient">csv string</param>
        /// <returns>Ingredients</returns>
        public static Ingredient GetIngredient (string ingredient)
        {
            string[] t = ingredient.Split(';');
            return new Ingredient() { Id = int.Parse(t[0]), Name = t[1], Price = float.Parse( t[2]) };
        }
    }
}
