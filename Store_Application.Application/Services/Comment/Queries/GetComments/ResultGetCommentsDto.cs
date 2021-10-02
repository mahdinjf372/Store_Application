using System;

namespace Store_Application.Application.Services.Comment.Queries.GetComments
{
    public class ResultGetCommentsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IRecommended { get; set; }
        public DateTime InsertTime { get; set; }
        public int LikesCount { get; set; }
        public int DislikesCount { get; set; }
        public byte Rate { get; set; }
        public UserDto User { get; set; }
    }
}
