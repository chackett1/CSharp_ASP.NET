using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PizzaPalace.Models
{
    //DropCreateDatabaseAlways
    //DropCreateDatabaseIfModelChanges
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Pizza"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Bread"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Drink"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Dessert"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Sauce"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Small Cheese",
                    Description = "This pizza is loaded with cheese.  A small pizza will feed 1-2 people.",
                    ImagePath="cheeseS.png",
                    UnitPrice = 8.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Medium Cheese",
                    Description = "This pizza is loaded with cheese.  A medium pizza will feed 1-3 people.",
                    ImagePath="cheeseM.png",
                    UnitPrice = 10.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Large Cheese",
                    Description = "This pizza is loaded with cheese.  A large pizza will feed 2-3 people.",
                    ImagePath="cheeseL.png",
                    UnitPrice = 12.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "XL Cheese",
                    Description = "This pizza is loaded with cheese.  A extra large pizza will feed 2-4 people.",
                    ImagePath="cheeseXL.png",
                    UnitPrice = 14.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Small Pepperoni",
                    Description = "This pizza is loaded with pepperoni.  A small pizza will feed 1-2 people.",
                    ImagePath="pepperoniS.png",
                    UnitPrice = 9.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Medium Pepperoni",
                    Description = "This pizza is loaded with pepperoni.  A medium pizza will feed 1-3 people.",
                    ImagePath="pepperoniM.png",
                    UnitPrice = 11.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Large Pepperoni",
                    Description = "This pizza is loaded with pepperoni.  A large pizza will feed 2-3 people.",
                    ImagePath="pepperoniL.png",
                    UnitPrice = 13.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "XL Pepperoni",
                    Description = "This pizza is loaded with pepperoni.  A extra large pizza will feed 2-4 people.",
                    ImagePath="pepperoniXL.png",
                    UnitPrice = 15.00,
                    CategoryID = 1
                }
            };

            return products;
        }
    }
}