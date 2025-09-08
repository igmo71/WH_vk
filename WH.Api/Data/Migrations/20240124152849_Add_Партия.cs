using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Партия : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Партия",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Партия_Type",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "РасчетНеЗавершен",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "РасчетПартий",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Партия",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType");

            migrationBuilder.DropColumn(
                name: "Партия_Type",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType");

            migrationBuilder.DropColumn(
                name: "РасчетНеЗавершен",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType");

            migrationBuilder.DropColumn(
                name: "РасчетПартий",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType");
        }
    }
}
