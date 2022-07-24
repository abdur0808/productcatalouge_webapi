using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.DB.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Description", "Name", "Price" },
                values: new object[] { "red", "Cricket Bat small", "Cricket_s", 10.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description", "Name", "Price" },
                values: new object[] { "green", "Cricket Bat medium", "Cricket_m", 15.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Description", "Name", "Price", "Size" },
                values: new object[] { "white", "Cricket Bat large", "Cricket_l", 20.0, "large" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 5, "red", "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", "Badminton_s", 10.0, "small" },
                    { 6, "white", "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", "Badminton_m", 15.0, "medium" },
                    { 7, "green", "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", "Badminton_l", 20.0, "medium" },
                    { 8, "blue", "rugby league and rugby union", "rugby_s", 5.0, "medium" },
                    { 9, "blue", "rugby league and rugby union", "rugby_m", 10.0, "medium" },
                    { 10, "blue", "rugby league and rugby union", "rugby_l", 15.0, "medium" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Description", "Name" },
                values: new object[] { "Red", "Cricket Bat", "Cricket" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Description", "Name" },
                values: new object[] { "white", "Badminton is a racquet sport played using racquets to hit a shuttlecock across a net", "Badminton" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Description", "Name", "Size" },
                values: new object[] { "blue", "rugby league and rugby union", "rugby ", "medium" });
        }
    }
}
