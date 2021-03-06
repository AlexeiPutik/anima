using ANIMA.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace ANIMA.Domain.Entities
{
    public class Post : BaseEntity, ILikeable, IPostable
    {
        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        public bool IsLiked { get; set; } = false;

        [Required]
        public int LikesCount { get; set; } = 0;

        [Required]
        public int CommentsCount { get; set; } = 0;

        [Required]
        public DateTime Date { get; } = DateTime.Now;
        
        public string Text { get; set; }

        public Guid SongId { get; set; }

        public Guid AlbumId { get; set; }
    }
}
