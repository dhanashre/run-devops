using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {

        public static readonly List<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "IPhone X",
                Description =" This phone is the company's biggest change its flagship smartphone",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"

            },
            new Product()
            {
                Name = "Samsung",
                Description =" This phone is the company's biggest change its flagship smartphone",
                ImageFile = "product-2.png",
                Price = 840.00M,
                Category = "Smart Phone"

            },
            new Product()
            {
                Name = "Xiomi Mi 9",
                Description =" This phone is the company's biggest change its flagship smartphone",
                ImageFile = "product-3.png",
                Price = 470.00M,
                Category = "White Appliances"

            },
            new Product()
            {
                Name = "HTC U11+ Plus",
                Description =" This phone is the company's biggest change its flagship smartphone",
                ImageFile = "product-4.png",
                Price = 700.00M,
                Category = "Smart Phone"

            },
            new Product()
            {
                Name = "Fridge",
                Description =" This phone is the company's biggest change its flagship smartphone",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Electronics"

            },


        };


    }
}
