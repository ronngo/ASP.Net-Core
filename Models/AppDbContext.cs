using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tessrt.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Posts> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Phía Nam Huế" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Trung Tâm Huế " });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Phía Đông Huế" });

            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 1,
                Title = "Gạo Lứt Huế",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
              
                ImageUrl = "https://media.istockphoto.com/photos/red-doors-in-hues-imperial-city-vietnam-picture-id638447848?b=1&k=6&m=638447848&s=170667a&w=0&h=qTIdh9lDz__y0hOZ0OzEKqejXaxgRMKFqqu6JA5I8TM=",
                CategoryId = 1
            });
            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 2,
                Title = "Thịt ba chỉ Huế",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                
                ImageUrl = "https://media.istockphoto.com/photos/pond-in-the-imperial-city-in-hue-vietnam-picture-id524152810?b=1&k=6&m=524152810&s=170667a&w=0&h=ZoMkyG1eLfmqzWQY-lyHc4ZPE0rz5KoCmfcSO50k0lk=",
                CategoryId = 2
            });
            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 3,
                Title = "Gạo Lào",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
               
                ImageUrl = "https://media.istockphoto.com/photos/wonderful-view-of-the-east-gate-hue-picture-id971966634?b=1&k=6&m=971966634&s=170667a&w=0&h=es06fFhnuKcEVf2xBdisiuvf4YchR2SXv3dtfR7swxQ=",
                CategoryId = 1
            });
            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 4,
                Title = "Mít trộn Huế",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
               
                ImageUrl = "https://media.istockphoto.com/photos/view-of-hoi-an-ancient-town-picture-id1154942577?b=1&k=6&m=1154942577&s=170667a&w=0&h=A3A_LpDguGfYCy1X8e_KLJbsp07skHYr4PPeNYnxbZM=",
                CategoryId = 3
            });
            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 5,
                Title = "Gạo Thơm xứ Quảng",
                Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
               
                ImageUrl = "https://media.istockphoto.com/photos/building-in-the-imperial-city-of-hue-vietnam-picture-id187741838?b=1&k=6&m=187741838&s=170667a&w=0&h=-nZVm_rOTr0HYTqlsdAmKxDitMaiB0XGPm2YUJrOBeg=",
                CategoryId = 1
            });

            modelBuilder.Entity<ProductTag>().HasKey(protag => new { protag.ProductId, protag.TagId });

            //Seeder data tag
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 1,
                Name = "Ăn gì ở Huế"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 2,
                Name = "Ở đâu tại Huế?"

            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 3,
                Name = "Địa điểm check-in tại Huế"

            });
        }
    }
}
