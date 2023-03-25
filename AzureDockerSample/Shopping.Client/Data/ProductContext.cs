using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public class ProductContext
    {
        public static readonly List<Product> products = new List<Product>{
            new Product()
            {
                Id = 1,
                Name="Acc",
                Price=10
            },
            new Product()
            {
                Id = 2,
                Name="Zsc",
                Price=14
            }
        };
    }
}
