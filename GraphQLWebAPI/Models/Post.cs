﻿namespace GraphQLWebAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User User { get; set; }
        public TimeOnly CreatedTime { get; set; } = TimeOnly.FromDateTime(DateTime.UtcNow);
    }
}
