using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_КОтгрузке : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "КОтгрузкеClosingBalance",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "КОтгрузкеExpense",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "КОтгрузкеOpeningBalance",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "КОтгрузкеReceipt",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "КОтгрузкеTurnover",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "КОтгрузкеClosingBalance",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "КОтгрузкеExpense",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "КОтгрузкеOpeningBalance",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "КОтгрузкеReceipt",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "КОтгрузкеTurnover",
                table: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");
        }
    }
}
