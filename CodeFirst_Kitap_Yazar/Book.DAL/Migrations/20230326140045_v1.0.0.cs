using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.WriterId);
                });

            migrationBuilder.CreateTable(
                name: "YazarKitaps",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YazarKitaps", x => new { x.BookId, x.WriterId });
                    table.ForeignKey(
                        name: "FK_YazarKitaps_Kitaps_BookId",
                        column: x => x.BookId,
                        principalTable: "Kitaps",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YazarKitaps_Yazars_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Yazars",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kitaps",
                columns: new[] { "BookId", "Name", "NumberOfPages", "Price" },
                values: new object[,]
                {
                    { 1, "Zamanın Kısa Tarihi", 255, 89m },
                    { 2, "Sürüngen İle Yılan ", 452, 30m },
                    { 3, "The Talisman", 290, 73.60m },
                    { 4, "Savaş Sanatı", 350, 69.99m },
                    { 5, "Evrenin Kısa Tarihi", 400, 25m },
                    { 6, "Zihin Uzayı", 420, 50m }
                });

            migrationBuilder.InsertData(
                table: "Yazars",
                columns: new[] { "WriterId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Stephen", "Hawking" },
                    { 2, "Leonard", "Mlodinow" },
                    { 3, "Margaret", "Atwood" },
                    { 4, "Graeme", "Gibson" },
                    { 5, "Stephen", "King" },
                    { 6, "Peter", "Straub" },
                    { 7, "Sun", "Tzu" },
                    { 8, "Lionel ", "Giles" }
                });

            migrationBuilder.InsertData(
                table: "YazarKitaps",
                columns: new[] { "BookId", "WriterId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 1 },
                    { 6, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_YazarKitaps_WriterId",
                table: "YazarKitaps",
                column: "WriterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YazarKitaps");

            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.DropTable(
                name: "Yazars");
        }
    }
}
