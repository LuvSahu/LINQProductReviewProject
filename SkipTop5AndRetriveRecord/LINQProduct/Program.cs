using LINQProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>();//list maintain the same order
            AddProductReviewIntoList(list);
            ProductReviewManagement.RetriveTop3ReviewBasedOnTheHighestRating(list);
            ProductReviewManagement.RetriveBasedOnProductIdAndRatig(list);
            ProductReviewManagement.CountEachProductID(list);
            ProductReviewManagement.RetriveProductIDAndRevies(list);
            ProductReviewManagement.SkipTop5DataRetriveRemaining(list);
            Console.ReadLine();

        }
        public static void IterateOverProductReview(List<ProductReview> list)
        {//here we are iterating through the list to display the productreview inside the list
            foreach (ProductReview product in list)
            {
                Console.WriteLine(product);//here it will go to the overeride method inside the ProductReview class
            }
        }


        public static void AddProductReviewIntoList(List<ProductReview> list)
        {                                 //this we called as objevt intialize
            list.Add(new ProductReview() { ProductId = 1, UserId = 101, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 2, UserId = 102, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 3, UserId = 103, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 4, UserId = 104, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 5, UserId = 105, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 6, UserId = 106, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 6, UserId = 107, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 7, UserId = 108, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 8, UserId = 109, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 9, UserId = 110, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 10, UserId = 111, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 11, UserId = 112, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 12, UserId = 113, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 13, UserId = 114, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 14, UserId = 115, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 15, UserId = 116, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 16, UserId = 117, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 17, UserId = 118, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 18, UserId = 119, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 19, UserId = 120, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 20, UserId = 121, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 21, UserId = 122, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 22, UserId = 123, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 23, UserId = 124, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 24, UserId = 125, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 25, UserId = 1, Review = "Good", IsLike = true, Rating = 8 });
            IterateOverProductReview(list);
        }
    }
}