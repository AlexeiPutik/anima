using ANIMA.Domain.Entities;
using ANIMA.Domain.Entities.Feedback;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain
{
    public class AppDbContext: IdentityDbContext<Author>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public override DbSet<Author> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "49784867-7e75-47e9-a5b5-e2f620ee5b81",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "6a16732c-c32f-4f78-ad87-f6c9c3ef7a8b",
                Name = "user",
                NormalizedName = "USER"
            });

            builder.Entity<Author>().HasData(new Author
            {
                Id = "2c48ee8a-d662-4b98-b3e5-7a6e6437d856",
                UserName = "Alexei Putik",
                NormalizedUserName = "ALEXEI PUTIK",
                Email = "alexei.putik@gmail.com",
                NormalizedEmail = "ALEXEI.PUTIK@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<Author>().HashPassword(null, "112233"),
                SecurityStamp = "secanima"
            });

            builder.Entity<Author>().HasData(new Author
            {
                Id = "5764b6ab-ee06-492c-afaf-3c01111b6ab9",
                UserName = "User Test",
                NormalizedUserName = "USER TEST",
                Email = "user.test@yopmail.com",
                NormalizedEmail = "USER.TEST@YOPMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<Author>().HashPassword(null, "112233"),
                SecurityStamp = "secanima"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "49784867-7e75-47e9-a5b5-e2f620ee5b81",
                UserId = "2c48ee8a-d662-4b98-b3e5-7a6e6437d856"
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "6a16732c-c32f-4f78-ad87-f6c9c3ef7a8b",
                UserId = "5764b6ab-ee06-492c-afaf-3c01111b6ab9"
            });

            builder.Entity<Post>().HasData(new Post
            {
                Id = new Guid("6abff99d-151f-4f50-9f6b-050a589be968"),
                AuthorId = new Guid("2c48ee8a-d662-4b98-b3e5-7a6e6437d856"),
                Text = "This is first post."
            });
        }
    }
}
