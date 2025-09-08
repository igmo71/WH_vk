using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_AccumulationRegisterТоварыВЯчейкахBalanceAndTurnovers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Дата",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ЕдиницаИзмерения_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Паллет_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Серия_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Склад_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Дата",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "ЕдиницаИзмерения_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "Паллет_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "Серия_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers");

            migrationBuilder.DropColumn(
                name: "Склад_Key",
                table: "wms_AccumulationRegister_ТоварыВЯчейках_BalanceAndTurnovers");
        }
    }
}
