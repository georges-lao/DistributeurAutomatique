using DistributeurAutomatique.Shared;
using System.Collections.Generic;

namespace UnitTest
{
    public class TestReader : IBeverageReader
    {
        List<Beverage> beverageList = new List<Beverage>() {
            new Beverage { Id = 1, Name = "Coffee" , Price = "1€", Description = "super coffee"},
            new Beverage { Id = 2, Name = "Tea", Price = "2€", Description = "super Tea" }
        };
        
        public IEnumerable<Beverage> GetBeverages()
        {
            return beverageList;
        }
    }
}
