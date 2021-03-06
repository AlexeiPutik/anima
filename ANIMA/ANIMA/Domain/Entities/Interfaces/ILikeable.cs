using ANIMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Interfaces
{
    public interface ILikeable
    {
        public bool IsLiked { get; set; }

        public int LikesCount { get; set; }
    }
}
