using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCatalogГруппыПользователей : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog_ГруппыПользователей",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Комментарий = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ГруппыПользователей", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ГруппыПользователей_Состав",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Пользователь_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ГруппыПользователей_Состав", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Catalog_ГруппыПользователей_Состав_Catalog_ГруппыПользователей_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Catalog_ГруппыПользователей",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_ГруппыПользователей_Состав");

            migrationBuilder.DropTable(
                name: "Catalog_ГруппыПользователей");
        }
    }
}
