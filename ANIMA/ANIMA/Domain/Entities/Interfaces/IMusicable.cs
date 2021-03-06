using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Interfaces
{
    public interface IMusicable
    {
        public List<Guid> ArtistIds { get; set; }

        public List<string> Genres { get; set; }

        public string Title { get; set; }

        public byte[] TitleImage { get; set; }

        public int Duration { get; set; }
    }
}
