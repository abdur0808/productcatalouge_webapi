using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.DB.Migrations
{
    public partial class initials3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A cricket bat is a specialised piece of equipment used by batters in the sport of cricket to hit the ball, typically consisting of a cane handle attached to a flat-fronted willow-wood blade. It may also be used by a batter who is making ground to avoid a run out, by holding the bat and touching the ground with it.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "As a rule, the full length of a cricket bat should reach to just below the waist on the cricketer");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "As a rule, the full length of a cricket bat should reach to just below the waist on the cricketer");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Size" },
                values: new object[] { "Rugby was invented in the early 19th century as a variation on football. It is a team sport where each player can really go all out. Rugby is a 15-a-side team sport. The object of the game is to ground the ball behind the opponent's try line, into what is called the in-goal area.", "small" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Description", "Price" },
                values: new object[] { "red", "Rugby was invented in the early 19th century as a variation on football. It is a team sport where each player can really go all out. Rugby is a 15-a-side team sport. The object of the game is to ground the ball behind the opponent's try line, into what is called the in-goal area.", 20.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Description", "Price", "Size" },
                values: new object[] { "white", "Rugby was invented in the early 19th century as a variation on football. It is a team sport where each player can really go all out. Rugby is a 15-a-side team sport. The object of the game is to ground the ball behind the opponent's try line, into what is called the in-goal area.", 30.0, "large" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ImageId", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 11, "red", "A T-shirt, or tee shirt, was originally worn only by men as an undershirt. Now it is defined as a short-sleeved, collarless undershirt or any outer shirt of a similar design.", "tshirt1", "T-shirt", 50.0, "small" },
                    { 12, "black", "A T-shirt, or tee shirt, was originally worn only by men as an undershirt. Now it is defined as a short-sleeved, collarless undershirt or any outer shirt of a similar design.", "tshirt2", "T-shirt-m", 25.0, "small" },
                    { 13, "black", "A T-shirt, or tee shirt, was originally worn only by men as an undershirt. Now it is defined as a short-sleeved, collarless undershirt or any outer shirt of a similar design.", "tshirt3", "T-shirt-m", 20.0, "large" },
                    { 14, "gray", "Shoes not only help our feet to heal but can also aid in support and stability of our foot. Not all feet are perfect, so properly fitting shoes can help align your feet, ankles, knees, hips and back to correct your gait and improve posture.", "Shoes1", "Shoes_s", 100.0, "small" },
                    { 15, "black", "Shoes not only help our feet to heal but can also aid in support and stability of our foot. Not all feet are perfect, so properly fitting shoes can help align your feet, ankles, knees, hips and back to correct your gait and improve posture.", "Shoes2", "Shoes_m", 80.0, "medium" },
                    { 16, "red", "Shoes not only help our feet to heal but can also aid in support and stability of our foot. Not all feet are perfect, so properly fitting shoes can help align your feet, ankles, knees, hips and back to correct your gait and improve posture.", "Shoes3", "Shoes_l", 60.0, "large" },
                    { 17, "blue", "It is designed to keep a consistent movement despite the motions caused by the person's activities. A wristwatch is designed to be worn around the wrist, attached by a watch strap or other type of bracelet, including metal bands, leather straps or any other kind of bracelet.", "watch1", "wrist_watch-s", 150.0, "small" },
                    { 18, "black", "It is designed to keep a consistent movement despite the motions caused by the person's activities. A wristwatch is designed to be worn around the wrist, attached by a watch strap or other type of bracelet, including metal bands, leather straps or any other kind of bracelet.", "watch2", "wrist_watch-m", 100.0, "medium" },
                    { 19, "white", "It is designed to keep a consistent movement despite the motions caused by the person's activities. A wristwatch is designed to be worn around the wrist, attached by a watch strap or other type of bracelet, including metal bands, leather straps or any other kind of bracelet.", "watch3", "wrist_watch-l", 70.0, "large" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Cricket Bat small");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Cricket Bat medium");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Cricket Bat large");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Size" },
                values: new object[] { "rugby league and rugby union", "medium" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Description", "Price" },
                values: new object[] { "blue", "rugby league and rugby union", 10.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Description", "Price", "Size" },
                values: new object[] { "blue", "rugby league and rugby union", 15.0, "medium" });
        }
    }
}
