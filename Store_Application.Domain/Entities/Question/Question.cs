using Store_Application.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Domain.Entities.Question
{
    public class Question : BaseEntity<int>
    {
        public string Text { get; set; }

        public bool AdminIsRead { get; set; }

        public bool ConfirmedByAdmin { get; set; }

        public int UserId { get; set; }
        public User.User User { get; set; }

        public int ProductId { get; set; }
        public Product.Product Product { get; set; }

        public int? ParentQuestionId { get; set; }
        public Question ParentQuestion { get; set; }

        public List<Question> Answers { get; set; }
    }
}
