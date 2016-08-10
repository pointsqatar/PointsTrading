using PointsTradingDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsTradingBusinessLayer
{
    public class ProdutsManager
    {
        public List<ProductDetail> GetProducts(string id = "")
        {
            var products = new List<ProductDetail>();
            using (var dbContext = new PointsTradingEntities())
            {
                if (id == string.Empty)
                {
                    products = (from prods in dbContext.ProductDetails
                                where prods.IsLatestProduct == true
                                select prods).ToList();
                }
                else
                {
                    int categoryId = Convert.ToInt32(id);
                    products = (from prods in dbContext.ProductDetails
                                where prods.ProductCategoryID == categoryId
                                select prods).ToList();
                }
            }
            return products;
        }


        public List<ProductCategory> GetProductCategories(string id = "")
        {
            var categories = new List<ProductCategory>();
            using (var dbContext = new PointsTradingEntities())
            {
                if (id == string.Empty)
                {
                    categories = (from category in dbContext.ProductCategories
                                  select category).ToList();
                }
                else
                {
                    int categoryId = Convert.ToInt32(id);
                    categories = (from category in dbContext.ProductCategories
                                  where category.CategoryID == categoryId
                                  select category).ToList();
                }
            }
            return categories;
        }
        
        public ProductDetail GetProductById(string id)
        {
            ProductDetail product = new ProductDetail();
            using (var dbContext = new PointsTradingEntities())
            {
                product = (from prod in dbContext.ProductDetails
                          where prod.ProductID == id
                          select prod).SingleOrDefault();
            }
            return product;
        }
    }
}
