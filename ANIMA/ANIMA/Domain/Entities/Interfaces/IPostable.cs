using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Interfaces
{
    public interface IPostable
    {
        public Guid AuthorId { get; set; }

        public DateTime Date { get; }

        public string Text { get; set; }
    }
}
