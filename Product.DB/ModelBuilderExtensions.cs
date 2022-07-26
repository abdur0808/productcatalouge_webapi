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
                new Product
                {
                    Id = 1,
                    Name = "Cricket_s",
                    Description = "A cricket bat is a specialised piece of equipment used by batters in the sport of cricket to hit the ball, typically consisting of a cane handle attached to a flat-fronted willow-wood blade. It may also be used by a batter who is making ground to avoid a run out, by holding the bat and touching the ground with it.",
                    Color = "red",
                    Size = "small",
                    Price = 10.00,
                    ImageId = "cricketbat1"
                },
                new Product
                {
                    Id = 2,
                    Name = "Cricket_m",
                    Description = "As a rule, the full length of a cricket bat should reach to just below the waist on the cricketer",
                    Color = "green",
                    Size = "medium",
                    Price = 15.00,
                    ImageId = "cricketbat2"
                },
                new Product
                {
                    Id = 3,
                    Name = "Cricket_l",
                    Description = "As a rule, the full length of a cricket bat should reach to just below the waist on the cricketer",
                    Color = "white",
                    Size = "large",
                    Price = 20.00,
                    ImageId = "cricketbat3"
                },
                new Product
                {
                    Id = 5,
                    Name = "Badminton_s",
                    Description = "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net",
                    Color = "red",
                    Size = "small",
                    Price = 10.00,
                    ImageId = "badminton1"
                },
                new Product
                {
                    Id = 6,
                    Name = "Badminton_m",
                    Description = "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net",
                    Color = "white",
                    Size = "medium",
                    Price = 15.00,
                    ImageId = "badminton2"
                },
                new Product
                {
                    Id = 7,
                    Name = "Badminton_l",
                    Description = "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net",
                    Color = "green",
                    Size = "medium",
                    Price = 20.00,
                    ImageId = "badminton3"
                },
               new Product
               {
                   Id = 8,
                   Name = "rugby_s",
                   Description = "Rugby was invented in the early 19th century as a variation on football. It is a team sport where each player can really go all out. Rugby is a 15-a-side team sport. The object of the game is to ground the ball behind the opponent's try line, into what is called the in-goal area.",
                   Color = "blue",
                   Size = "small",
                   Price = 5.00,
                   ImageId = "rogby1"
               },
               new Product
               {
                   Id = 9,
                   Name = "rugby_m",
                   Description = "Rugby was invented in the early 19th century as a variation on football. It is a team sport where each player can really go all out. Rugby is a 15-a-side team sport. The object of the game is to ground the ball behind the opponent's try line, into what is called the in-goal area.",
                   Color = "red",
                   Size = "medium",
                   Price = 20.00,
                   ImageId = "rogby2"
               },
               new Product
               {
                   Id = 10,
                   Name = "rugby_l",
                   Description = "Rugby was invented in the early 19th century as a variation on football. It is a team sport where each player can really go all out. Rugby is a 15-a-side team sport. The object of the game is to ground the ball behind the opponent's try line, into what is called the in-goal area.",
                   Color = "white",
                   Size = "large",
                   Price = 30.00,
                   ImageId = "rogby3"
               },

                new Product
                {
                    Id = 11,
                    Name = "T-shirt",
                    Description = "A T-shirt, or tee shirt, was originally worn only by men as an undershirt. Now it is defined as a short-sleeved, collarless undershirt or any outer shirt of a similar design.",
                    Color = "red",
                    Size = "small",
                    Price = 50.00,
                    ImageId = "tshirt1"
                },
                new Product
                {
                    Id = 12,
                    Name = "T-shirt-m",
                    Description = "A T-shirt, or tee shirt, was originally worn only by men as an undershirt. Now it is defined as a short-sleeved, collarless undershirt or any outer shirt of a similar design.",
                    Color = "black",
                    Size = "small",
                    Price = 25.00,
                    ImageId = "tshirt2"
                },
                new Product
                {
                    Id = 13,
                    Name = "T-shirt-m",
                    Description = "A T-shirt, or tee shirt, was originally worn only by men as an undershirt. Now it is defined as a short-sleeved, collarless undershirt or any outer shirt of a similar design.",
                    Color = "black",
                    Size = "large",
                    Price = 20.00,
                    ImageId = "tshirt3"
                },
                new Product
                {
                    Id = 14,
                    Name = "Shoes_s",
                    Description = "Shoes not only help our feet to heal but can also aid in support and stability of our foot. Not all feet are perfect, so properly fitting shoes can help align your feet, ankles, knees, hips and back to correct your gait and improve posture.",
                    Color = "gray",
                    Size = "small",
                    Price = 100.00,
                    ImageId = "Shoes1"
                },
                new Product
                {
                    Id = 15,
                    Name = "Shoes_m",
                    Description = "Shoes not only help our feet to heal but can also aid in support and stability of our foot. Not all feet are perfect, so properly fitting shoes can help align your feet, ankles, knees, hips and back to correct your gait and improve posture.",
                    Color = "black",
                    Size = "medium",
                    Price = 80.00,
                    ImageId = "Shoes2"
                },
                new Product
                {
                    Id =16,
                    Name = "Shoes_l",
                    Description = "Shoes not only help our feet to heal but can also aid in support and stability of our foot. Not all feet are perfect, so properly fitting shoes can help align your feet, ankles, knees, hips and back to correct your gait and improve posture.",
                    Color = "red",
                    Size = "large",
                    Price = 60.00,
                    ImageId = "Shoes3"
                },
               new Product
               {
                   Id = 17,
                   Name = "wrist_watch-s",
                   Description = "It is designed to keep a consistent movement despite the motions caused by the person's activities. A wristwatch is designed to be worn around the wrist, attached by a watch strap or other type of bracelet, including metal bands, leather straps or any other kind of bracelet.",
                   Color = "blue",
                   Size = "small",
                   Price = 150.00,
                   ImageId = "watch1"
               },
               new Product
               {
                   Id =18,
                   Name = "wrist_watch-m",
                   Description = "It is designed to keep a consistent movement despite the motions caused by the person's activities. A wristwatch is designed to be worn around the wrist, attached by a watch strap or other type of bracelet, including metal bands, leather straps or any other kind of bracelet.",
                   Color = "black",
                   Size = "medium",
                   Price = 100.00,
                   ImageId = "watch2"
               },
               new Product
               {
                   Id = 19,
                   Name = "wrist_watch-l",
                   Description = "It is designed to keep a consistent movement despite the motions caused by the person's activities. A wristwatch is designed to be worn around the wrist, attached by a watch strap or other type of bracelet, including metal bands, leather straps or any other kind of bracelet.",
                   Color = "white",
                   Size = "large",
                   Price = 70.00,
                   ImageId = "watch3"
               }
            );
        }
    }
}
