using ANIMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Post> posts)
        {
            this.Posts = posts.ToList();
        }

        public List<Post> Posts { get; set; }
    }
}
