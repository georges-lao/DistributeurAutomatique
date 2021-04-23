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
            //var csvTable = new DataTable();
            //using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"..\4-DataStorage\beveragesList.csv")), true))
            //{
            //    csvTable.Load(csvReader);
            //}
            var result = new List<Beverage>();
            result.Add(new Beverage { Id = 1, Name = "Coffee" , Price = "1€", Description = "super coffee"});
            result.Add(new Beverage { Id = 2, Name = "Tea", Price = "2€", Description = "super Tea" });
            return result;
        }
    }
}
