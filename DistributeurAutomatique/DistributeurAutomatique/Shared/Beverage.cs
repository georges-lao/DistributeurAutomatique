namespace DistributeurAutomatique.Shared
{
    /// <summary>
    /// class represent beverage object
    /// </summary>
    public class Beverage
    {
        /// <summary>
        /// BeverageId
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Beverage Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Recipe ID
        /// </summary>
        public int RecipeId { get; set; }

        /// <summary>
        /// Beverage Price
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Beverage Description
        /// </summary>
        public string Description { get; set; }
    }
}
