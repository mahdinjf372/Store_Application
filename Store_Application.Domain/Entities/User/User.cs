using Store_Application.Domain.Entities.Common;
using System;
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

        public int RoleId { get; set; }

        public Role Role { get; set; }

        //public List<QuestionAndAnswer> QuestionsAndAnswers { get; set; }
        //public List<ProductComment> ProductComments { get; set; }

        //public List<Order> Orders { get; set; }

        //public List<ProductCompaire> Compaires { get; set; }

        //public List<Product> FavoriteProducts { get; set; }
        
    }
}
