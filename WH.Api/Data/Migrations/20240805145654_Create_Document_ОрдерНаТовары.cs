using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_Document_ОрдерНаТовары : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document_ПриходныйОрдерНаТовары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладскаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Отправитель = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Отправитель_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВсегоМест = table.Column<int>(type: "int", nullable: false),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ПриходныйОрдерНаТовары", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_РасходныйОрдерНаТовары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладскаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Получатель = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Получатель_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВсегоМест = table.Column<int>(type: "int", nullable: false),
                    ДатаОтгрузки = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_РасходныйОрдерНаТовары", x => x.Ref_Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document_ПриходныйОрдерНаТовары");

            migrationBuilder.DropTable(
                name: "Document_РасходныйОрдерНаТовары");
        }
    }
}
