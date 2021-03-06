using ANIMA.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain
{
    public class DataManager
    {
        public IPostsRepository PostsRepository { get; set; }
        
        public DataManager(IPostsRepository postsRepository)
        {
            this.PostsRepository = postsRepository;
        }
    }
}
