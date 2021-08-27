using Microsoft.EntityFrameworkCore.Migrations;

namespace RetailCompanyProject.Migrations
{
    public partial class v001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaptopId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "Color", "ImageURL", "Name", "Price", "Quantity", "Screen" },
                values: new object[,]
                {
                    { 1, "Grey", "lenovo.jpg", "Lenevo", 3510m, 30, "13 inch" },
                    { 2, "Natural Silver", "hp.png", "HP", 4100m, 40, "14 inch" },
                    { 3, "S.Grey", "MacBook.jpeg", "Apple MacBook Air 2020", 4899m, 50, "13 inch" },
                    { 4, "Silver", "asus.jpeg", "Asus X415", 2399m, 25, "14 inch" },
                    { 5, "Silver", "dell.jpeg", "Dell XPS", 5759m, 10, "13 inch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Laptop",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
