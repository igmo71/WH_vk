using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_ОприходованиеИзлишковТоваров : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document_ОприходованиеИзлишковТоваров",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПересчетТоваров_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Основание = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Основание_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ОприходованиеИзлишковТоваров", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ОприходованиеИзлишковТоваров_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ОприходованиеИзлишковТоваров_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ОприходованиеИзлишковТоваров_Товары_Document_ОприходованиеИзлишковТоваров_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ОприходованиеИзлишковТоваров",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document_ОприходованиеИзлишковТоваров_Товары");

            migrationBuilder.DropTable(
                name: "Document_ОприходованиеИзлишковТоваров");
        }
    }
}
