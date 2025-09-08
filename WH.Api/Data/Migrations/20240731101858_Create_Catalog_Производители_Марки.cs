using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_Catalog_Производители_Марки : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Марка_Key",
                table: "Catalog_Номенклатура",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Производитель_Key",
                table: "Catalog_Номенклатура",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Catalog_Марки",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Производитель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Марки", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Производители",
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
                    table.PrimaryKey("PK_Catalog_Производители", x => x.Ref_Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_Марки");

            migrationBuilder.DropTable(
                name: "Catalog_Производители");

            migrationBuilder.DropColumn(
                name: "Марка_Key",
                table: "Catalog_Номенклатура");

            migrationBuilder.DropColumn(
                name: "Производитель_Key",
                table: "Catalog_Номенклатура");
        }
    }
}
