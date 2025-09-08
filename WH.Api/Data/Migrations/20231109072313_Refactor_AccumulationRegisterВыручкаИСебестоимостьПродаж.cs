using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Refactor_AccumulationRegisterВыручкаИСебестоимостьПродаж : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "АналитикаУчетаПартий_Key",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "АналитикаУчетаПартий_Key",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }
    }
}
