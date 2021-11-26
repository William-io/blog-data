using System;

namespace Blog.Models
{
    public class Post
    {
        // [Id] INT NOT NULL IDENTITY(1, 1),
        // [CategoryId] INT NOT NULL,
        // [AuthorId] INT NOT NULL,
        // [Title] VARCHAR(160) NOT NULL,
        // [Summary] VARCHAR(255) NOT NULL,
        // [Body] TEXT NOT NULL,
        // [Slug] VARCHAR(80) NOT NULL,
        // [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
        // [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}