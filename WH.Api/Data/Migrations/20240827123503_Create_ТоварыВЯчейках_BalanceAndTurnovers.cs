using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_ТоварыВЯчейках_BalanceAndTurnovers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Ячейка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    КоличествоTurnover = table.Column<double>(type: "float", nullable: false),
                    КоличествоReceipt = table.Column<double>(type: "float", nullable: false),
                    КоличествоExpense = table.Column<double>(type: "float", nullable: false),
                    КоличествоClosingBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers");
        }
    }
}
