using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp7.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "t be shock, awe, or any other strongly felt emotion. In these such situations one must exclaim 'Bruh!', typically in a low tone of voice. Typically only men will exclaim using the word 'bruh', however, the S.O.B. (Society of Bruh) is a progressive union full of verified gamer bros and care not whether man nor woman exclaims with the word 'bruh'.", "https://static.truckersmp.com/images/vtc/logo/21823.1594940844.png", 9.99m, "Ldssdabas" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "ffdfdffdfd", "https://i1.sndcdn.com/artworks-WUn6AbCdLf93PTsy-G96wBw-t500x500.jpg", 9.99m, "Ate" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "ffdfd", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS2N6mPp7pI4GYStZ1HR9RKsXsvdzr3GT8wXA&usqp=CAU", 9.99m, "Alio" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
