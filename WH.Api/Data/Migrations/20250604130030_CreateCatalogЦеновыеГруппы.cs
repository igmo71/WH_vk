using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCatalogЦеновыеГруппы : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ЦеноваяГруппа_Key",
                table: "Catalog_Номенклатура",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Catalog_ЦеновыеГруппы",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ЦеновыеГруппы", x => x.Ref_Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_ЦеновыеГруппы");

            migrationBuilder.DropColumn(
                name: "ЦеноваяГруппа_Key",
                table: "Catalog_Номенклатура");
        }
    }
}
