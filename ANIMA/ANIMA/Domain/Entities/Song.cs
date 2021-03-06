using ANIMA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Entities
{
    public class Song : BaseEntity, IMusicable
    {
        public Guid AlbumId { get; set; }

        [Required]
        public List<Guid> ArtistIds { get; set; } = new List<Guid>();

        [Required]
        public string Title { get; set; }

        [Required]
        public List<string> Genres { get; set; } = new List<string>();

        [Required]
        public int Duration { get; set; }

        public int Bpm { get; set; }

        public byte[] TitleImage { get; set; }
    }
}
