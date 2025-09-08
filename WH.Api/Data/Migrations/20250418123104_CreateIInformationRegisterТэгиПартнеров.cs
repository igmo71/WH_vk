using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateIInformationRegisterТэгиПартнеров : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog_ТэгиПартнеров",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ТэгиПартнеров", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "InformationRegister_ТэгиПартнеров",
                columns: table => new
                {
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Тэг_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationRegister_ТэгиПартнеров", x => new { x.Партнер_Key, x.Тэг_Key });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_ТэгиПартнеров");

            migrationBuilder.DropTable(
                name: "InformationRegister_ТэгиПартнеров");
        }
    }
}
