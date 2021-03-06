using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Product
{
    public class Product : BaseEntity<int>
    {
        public string Title { get; set; }

        public string ShortDescription { get; set; }
        
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string TagsForSearch { get; set; }

        public decimal DiscountAmount { get; set; }

        public int Inventory { get; set; }
        public bool Displayed { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }

        #region Relations

        public Category Category { get; set; }

        public Brand Brand { get; set; }
        
        public ICollection<ProductFeature> Features { get; set; }

        public ICollection<ProductImage> Images { get; set; }
        
        public ICollection<ProductSlider> ProductSliders { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Question.Question> Questions { get; set; }
        public ICollection<Comment.Comment> Comments { get; set; }
        public ICollection<Favorite.Favorite> Favorites { get; set; }
        public ICollection<Compare.Compare> Compares { get; set; }
        public ICollection<Tag> Tags { get; set; }

        #endregion
    }

}
