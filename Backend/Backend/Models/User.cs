﻿using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname{ get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        [JsonIgnore]
        public ICollection<SavedPost> SavedPosts { get; set; }
        public ICollection<Comment> Comments { get; set; } // Users' comments
        public ICollection<Like> Likes { get; set; } // Users' likes
    }
}
