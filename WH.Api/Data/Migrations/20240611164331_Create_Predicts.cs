using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_Predicts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WhsProductData");

            migrationBuilder.DropTable(
                name: "WhsOrders");

            migrationBuilder.CreateTable(
                name: "DataMining_Predicts",
                columns: table => new
                {
                    НоменклатураВидПодвидKey = table.Column<string>(type: "nvarchar(73)", maxLength: 73, nullable: false),
                    WeekNum = table.Column<int>(type: "int", nullable: false),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Вес = table.Column<float>(type: "real", nullable: false),
                    ВидНоменклатуры_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПодвидНоменклатуры_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataMining_Predicts", x => new { x.WeekNum, x.Склад, x.НоменклатураВидПодвидKey });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataMining_Predicts");

            migrationBuilder.CreateTable(
                name: "WhsOrders",
                columns: table => new
                {
                    Документ_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Вес = table.Column<float>(type: "real", nullable: false),
                    ВесовойКоэффициент = table.Column<int>(type: "int", nullable: false),
                    Дата = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Документ_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КоличествоСтрок = table.Column<int>(type: "int", nullable: false),
                    Номер = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ответственный_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Ответственный_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ОтправительПолучатель_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ОтправительПолучатель_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Проведен = table.Column<bool>(type: "bit", nullable: false),
                    Склад_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СрокВыполнения = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ТипОчереди = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЭтоПеремещение = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhsOrders", x => x.Документ_Id);
                });

            migrationBuilder.CreateTable(
                name: "WhsProductData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditingCauseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Артикул = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Вес = table.Column<float>(type: "real", nullable: false),
                    Документ_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Документ_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КоличествоПлан = table.Column<float>(type: "real", nullable: false),
                    КоличествоФакт = table.Column<float>(type: "real", nullable: false),
                    Номенклатура_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Номенклатура_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НомерСтроки = table.Column<int>(type: "int", nullable: false),
                    Отгрузить = table.Column<bool>(type: "bit", nullable: false),
                    ТипУпаковки = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Упаковка_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhsProductData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhsProductData_WhsOrders_Документ_Id",
                        column: x => x.Документ_Id,
                        principalTable: "WhsOrders",
                        principalColumn: "Документ_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WhsProductData_Документ_Id",
                table: "WhsProductData",
                column: "Документ_Id");
        }
    }
}
