using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.DB
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Cricket_s", Description = "Cricket Bat small", Color="red", Size="small",Price =10.00, ImageId = "cricketbat1" },
                new Product { Id = 2, Name = "Cricket_m", Description = "Cricket Bat medium", Color = "green", Size = "medium", Price = 15.00, ImageId = "cricketbat2" },
                new Product { Id = 3, Name = "Cricket_l", Description = "Cricket Bat large", Color = "white", Size = "large", Price = 20.00, ImageId = "cricketbat3" },
                new Product { Id = 5, Name = "Badminton_s", 
                     Description = "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", 
                     Color = "red", Size = "small", Price = 10.00, ImageId = "badminton1" },
                new Product { Id = 6, Name = "Badminton_m", 
                    Description = "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", 
                    Color = "white", Size = "medium", Price = 15.00, ImageId = "badminton2" },
                new Product { Id = 7, Name = "Badminton_l", 
                    Description = "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", 
                    Color="green", Size="medium", Price = 20.00, ImageId = "badminton3" },
               new Product { Id = 8, Name = "rugby_s", Description = "rugby league and rugby union", Color = "blue", Size = "medium", Price = 5.00, ImageId = "rogby1" },
               new Product { Id = 9, Name = "rugby_m", Description = "rugby league and rugby union", Color = "blue", Size = "medium", Price = 10.00, ImageId = "rogby2" },
               new Product { Id = 10, Name = "rugby_l", Description = "rugby league and rugby union", Color = "blue", Size = "medium", Price = 15.00, ImageId = "rogby3" }
            );
        }
    }
}
