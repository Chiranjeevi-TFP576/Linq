using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewmanagement
{
    public class Management
    {
        //Uc2
        public void TopRecord(List<ProductReview> listproductReviews)
        {
            var recordData = (from ProductReview in listproductReviews
                              orderby ProductReview.Rating descending
                              select ProductReview
                            ).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + list.Rating);
            }

        }
        //UC3
        public void selectedRecords(List<ProductReview> listproductReviews)
        {
            var recordData = (from ProductReview in listproductReviews
                              where (ProductReview.ProductId == 1 || ProductReview.ProductId == 4 || ProductReview.ProductId == 9)
                              && ProductReview.Rating > 3
                              select ProductReview
                               );

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
        //UC4
        public void retriveCountRecord(List<ProductReview> listproductReviews)
        {

            var recordData = listproductReviews.GroupBy(x => x.ProductId).Select(x => new { productId = x.Key, count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.productId + "-----------------" + list.count);
            }
        }

        //UC5
        public void RetriveProductId(List<ProductReview> listproductReviews)
        {
            var recordData = listproductReviews.Select(x => x.ProductId).ToList();
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list);
            }

        }
        //UC6
        public void SkipTop5Records(List<ProductReview> listproductReviews)
        {
            var recorData = listproductReviews.Skip(5).ToList();
            foreach (var list in recorData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
        public void RetriveIsLikeTrue(List<ProductReview> listproductReviews)
        {
            var recordData = listproductReviews.Select(x => x.IsLike=true).ToList();
            foreach (var list in recordData)
            {
                Console.WriteLine("IsLike:-" + list);
            }

        }

    }
}
