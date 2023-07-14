using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class ProductManagement
    { 
        public static void Top3Record(List<ProductReview> lstobj)
        {
            var Product= (from product in lstobj orderby product.Rating descending select product).Take(3) ;

            foreach (var products in Product)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(products.ProductId + " | " + products.UserId + " | " +
                                  products.Review + " | " + products.Rating + " | " + products.IsLike);
                Console.WriteLine("-------------");
            }
        }

        public static void GetSelectedValues(List<ProductReview> lstobj)
        {
            var ProductData = from product in lstobj
                              where (product.Review == 3 && product.ProductId == 1 ||
                                     product.Review > 3 && product.ProductId == 3) select product;
           
            foreach (var products in ProductData)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(products.ProductId + " | " + products.UserId + " | " +
                                  products.Review + " | " + products.Rating + " | " + products.IsLike);
                Console.WriteLine("-------------");
            }
        }

        public static void GetCount(List<ProductReview> lstobj)
        {
            var productdata= lstobj.GroupBy(x => x.ProductId).Select(x => new( ProductId= x.Key , Count=x.Count)) ;
        }
    }
}
