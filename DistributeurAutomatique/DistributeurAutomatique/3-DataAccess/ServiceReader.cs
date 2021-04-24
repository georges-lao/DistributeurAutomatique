using DistributeurAutomatique.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace DistributeurAutomatique.DataAccess
{
    public class ServiceReader : IBeverageReader
    {
        /// <summary>
        /// method request beverage list from data source
        /// </summary>
        /// <returns>list of beverage</returns>
        public IEnumerable<Beverage> GetBeverages()
        {
            try
            {
                var result = new List<Beverage>();
                var recipes = getRecipeList();
                var ingredients = GetIngredients();
                //TODO : set file path in parameter
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"..\..\4-DataStorage\beveragesList.csv")), true))
                {
                    
                    foreach (var item in csvReader.ToList())
                    {
                        result.Add(DataToBeverageConverter.GetBeverage(item[0], recipes, ingredients));
                    }
                   
                }
                return result;
            }
            catch (Exception)
            {
                // log and exception policy
                throw;
            }
        }

        /// <summary>
        /// returne list of beverage recipe
        /// </summary>
        /// <returns>list string</returns>
        private List<string> getRecipeList()
        {
            try
            {
                var result = new List<string>();
                //TODO : set file path in parameter
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"..\..\4-DataStorage\Recipes.csv")), true))
                {
                    foreach (var item in csvReader.ToList())
                    {
                        result.Add(item[0]);
                    }
                }
                return result;
            }
            catch (Exception)
            {
                // log and exception policy
                throw;
            }            
        }

        /// <summary>
        /// return list of Beverage ingredients
        /// </summary>
        /// <returns>list of ingredients</returns>
        private List<Ingredient> GetIngredients ()
        {
            try
            {
                var result = new List<Ingredient>();
                //TODO : set file path in parameter
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"..\..\4-DataStorage\Ingredients.csv")), true))
                {
                    foreach (var item in csvReader.ToList())
                    {
                        result.Add(DataToBeverageConverter.GetIngredient(item[0]));
                    }
                }
                return result;
            }
            catch (Exception)
            {
                // log and exception policy
                throw;
            }
        }
    }
}
