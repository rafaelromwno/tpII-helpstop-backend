namespace HelpApp.Domain.Entities
{
    public class Product
    {
        #region Attributes

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }

        #endregion

        #region Constructors

        public Product(string name, string description, decimal price, int stock, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public Category Category { get; set; }

        #endregion
    }
}
