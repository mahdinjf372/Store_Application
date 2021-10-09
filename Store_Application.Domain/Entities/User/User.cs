using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Common;
using Store_Application.Domain.Entities.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Store_Application.Domain.Entities.User
{
    public class User:BaseEntity<int>
    {
        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public byte? age { get; set; }
     
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ActiveCode { get; set; }

        public bool isActive { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
        public ICollection<Cart.Cart> Carts { get; set; }
        public ICollection<Order.Order> Orders { get; set; }
        public ICollection<RequestPay> RequestPays { get; set; }
        public ICollection<Question.Question> Questions { get; set; }
        public ICollection<Comment.Comment> Comments { get; set; }
        public ICollection<Comment.Like> Likes { get; set; }
        public ICollection<Comment.Dislike> Dislikes { get; set; }
        public ICollection<Favorite.Favorite> Favorites { get; set; }
        public ICollection<Compare.Compare> Compares { get; set; }
    }
}
