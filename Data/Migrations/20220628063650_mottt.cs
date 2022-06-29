using Microsoft.EntityFrameworkCore.Migrations;

namespace Asm1670.Data.Migrations
{
    public partial class mottt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    CartId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "Amount" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "Age", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Hai Duong", 20, "cuongbuiqqq", "Bui Duc Cuong", "0843034237" },
                    { 2, "Hai Duong", 20, "cuongbuiqqq", "Bui Duc Cuong", "0843034237" },
                    { 3, "Hai Duong", 20, "cuongbuiqqq", "Bui Duc Cuong", "0843034237" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CartId", "CustomerId", "Price", "Title" },
                values: new object[] { 1, 1, 1, 13000f, "Doraemon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CartId", "CustomerId", "Price", "Title" },
                values: new object[] { 2, 2, 2, 13000f, "Doraemon" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CartId", "CustomerId", "Price", "Title" },
                values: new object[] { 3, 3, 3, 13000f, "Doraemon" });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CartId",
                table: "Book",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CustomerId",
                table: "Book",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
