using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_ВидыДеятельности : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog_ВидыДеятельности",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ВидыДеятельности", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Партнеры_ВидыДеятельности",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    ВидДеятельности_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Партнеры_ВидыДеятельности", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Catalog_Партнеры_ВидыДеятельности_Catalog_Партнеры_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Catalog_Партнеры",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_ВидыДеятельности");

            migrationBuilder.DropTable(
                name: "Catalog_Партнеры_ВидыДеятельности");
        }
    }
}
