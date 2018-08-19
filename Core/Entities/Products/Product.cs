namespace Core.Entities.Products
{
    /// <summary>
    ///  Domain model class for a Product. 
    /// </summary>
    public class Product : EntityBase<int>
    {
        public string Name { get; set; }

        // Add other properties here
    }
}
