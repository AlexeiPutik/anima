using ANIMA.Domain.Entities;
using ANIMA.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ANIMA.Domain.Repositories.EntityFramework
{
    public class EFPostsRepository : IPostsRepository
    {
        private readonly AppDbContext context;

        public EFPostsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void CreatePost(Post post)
        {
            this.context.Posts.Add(post);

            this.context.SaveChanges();
        }

        public void DeletePost(Guid id)
        {
            this.context.Posts.Remove(new Post { Id = id });

            this.context.SaveChanges();
        }

        public Post GetPost(Guid postId)
        {
            return this.context.Posts.FirstOrDefault(p => p.Id == postId);
        }

        public IQueryable<Post> GetPostsFromAuthor(Guid authorId)
        {
            return this.context.Posts.Where(p => p.AuthorId == authorId);
        }

        public void SavePost(Post post)
        {
            this.context.Entry(post).State = EntityState.Modified;

            this.context.SaveChanges();
        }
    }
}
