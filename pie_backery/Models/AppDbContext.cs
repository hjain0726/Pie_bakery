using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pie_backery.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "All-fruity pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "All-cheesey pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal Pies", Description = "All-seasonal pies" });

            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = "1", Name = "Strawberry Pie", CategoryId = 1, Price = 15.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Long long description",ImageUrl = "https://media.istockphoto.com/photos/whole-cherry-pie-picture-id535475493?k=6&m=535475493&s=612x612&w=0&h=yyG800xq7-noeZMUuCcSvieN_Pq7k_hY6y7AbISmz-s=", Instock = true, IsPieOfTheWeek = true, ImageThumbnailUrl = "https://media.istockphoto.com/photos/whole-cherry-pie-picture-id535475493?k=6&m=535475493&s=612x612&w=0&h=yyG800xq7-noeZMUuCcSvieN_Pq7k_hY6y7AbISmz-s=" });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = "2", Name = "Cheese Cake", CategoryId = 2,Price = 10.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Long long description", ImageUrl = "https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg", Instock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://www.landolakes.com/RecipeManagementSystem/media/Recipe-Media-Files/Recipes/Retail/x17/16800-blue-ribbon-apple-pie-600x600.jpg?ext=.jpg" });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = "3", Name = "Rhubarb Pie", CategoryId = 1,Price = 11.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Long long description", ImageUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_832/recipes/chicken_pie_24044_16x9.jpg", Instock = false, IsPieOfTheWeek = true, ImageThumbnailUrl = "https://ichef.bbci.co.uk/food/ic/food_16x9_832/recipes/chicken_pie_24044_16x9.jpg" });
            modelBuilder.Entity<Pie>().HasData(new Pie { PieId = "4", Name = "Pumpkin Pie", CategoryId = 3, Price = 12.95M, ShortDescription = "Lorem Ipsum", LongDescription = "Long long description", ImageUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg", Instock = true, IsPieOfTheWeek = false, ImageThumbnailUrl = "https://food.fnr.sndimg.com/content/dam/images/food/fullset/2009/6/15/0/JI_20731_s4x3.jpg.rend.hgtvcom.826.620.suffix/1371589402748.jpeg" });
        }
    }
}
           
        
      
       