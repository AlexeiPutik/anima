using ANIMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Repositories.Abstract
{
    public interface IPostsRepository
    {
        Post GetPost(Guid postId);

        IQueryable<Post> GetPostsFromAuthor(Guid authorId);

        void CreatePost(Post post);

        void DeletePost(Guid id);

        void SavePost(Post post);
    }
}
