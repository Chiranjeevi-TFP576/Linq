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
    }
}
