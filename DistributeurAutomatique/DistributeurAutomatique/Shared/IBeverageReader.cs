using System.Collections.Generic;

namespace DistributeurAutomatique.Shared
{
    public interface IBeverageReader
    {
        /// <summary>
        /// method request beverage list from data source
        /// </summary>
        /// <returns>list of beverage</returns>
        IEnumerable<Beverage> GetBeverages();
    }
}
