using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_AccumulationRegisterСебестоимостьТоваровBalanceAndTurnovers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulationRegister_СебестоимостьТоваров_BalanceAndTurnovers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КоличествоOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    КоличествоTurnover = table.Column<double>(type: "float", nullable: false),
                    КоличествоReceipt = table.Column<double>(type: "float", nullable: false),
                    КоличествоExpense = table.Column<double>(type: "float", nullable: false),
                    КоличествоClosingBalance = table.Column<double>(type: "float", nullable: false),
                    СтоимостьOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    СтоимостьTurnover = table.Column<double>(type: "float", nullable: false),
                    СтоимостьReceipt = table.Column<double>(type: "float", nullable: false),
                    СтоимостьExpense = table.Column<double>(type: "float", nullable: false),
                    СтоимостьClosingBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_СебестоимостьТоваров_BalanceAndTurnovers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_СебестоимостьТоваров_BalanceAndTurnovers");
        }
    }
}
