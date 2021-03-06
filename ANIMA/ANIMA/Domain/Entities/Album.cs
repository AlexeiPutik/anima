using ANIMA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Entities
{
    public class Album : BaseEntity, ILikeable, IMusicable
    {

        [Required]
        public List<Guid> ArtistIds { get; set; }

        [Required]
        public string Title { get; set; }

        public byte[] TitleImage { get; set; }

        [Required]
        public List<Guid> SongsId { get; set; } = new List<Guid>();

        [Required]
        public List<string> Genres { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public bool IsLiked { get; set; } = false;

        [Required]
        public int LikesCount { get; set; } = 0;
    }
}
