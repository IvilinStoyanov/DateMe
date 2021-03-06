using System;
using System.Collections.Generic;

namespace DateApp.API.Models
{
    public class Post
    {
        public Post()
        {
            Created = DateTime.Now;
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}