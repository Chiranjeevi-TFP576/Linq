namespace ProductReviewmanagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Management Problem Statement");
            //UC1
            List<ProductReview> listProducts = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 2, UserId = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 2, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 2, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 5, UserId = 3, Rating = 2, Review = "nice", IsLike = false },
                new ProductReview() { ProductId = 6, UserId = 4, Rating = 1, Review = "Bad", IsLike = false },
                new ProductReview() { ProductId = 7, UserId = 3, Rating = 1.5, Review = "nice", IsLike = false },
                new ProductReview() { ProductId = 8, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 9, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 11, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 12, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 13, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 14, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 15, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 16, UserId = 10, Rating = 4, Review = "nice", IsLike = true },
            };
            //foreach (var list in listProducts)
            //{
            //    Console.WriteLine("ProductId:" + list.ProductId + " " + "UserId:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review" + list.Review + " " + "IsLike" + list.IsLike);
            //}

            //Uc2
            Management management = new Management();
            management.TopRecord(listProducts);



        }

    }

}