using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProduct
{
    public class ProductReview
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Review { get; set; }//here review good,avarage,poorQuality
        public bool IsLike { get; set; }
        public int Rating { get; set; }//1 to 10
        public override string ToString()//it will print each object values with out doing it manually in main
        {
            return $"ProductId:{ProductId} UserId: {UserId} Review: {Review} IsLike: {IsLike} Rating: {Rating}";
        }
    }
}

