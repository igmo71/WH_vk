using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Recorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recorder",
                table: "InformationRegister_ЦеныНоменклатуры_RecordType");

            migrationBuilder.DropColumn(
                name: "Recorder_Type",
                table: "InformationRegister_ЦеныНоменклатуры_RecordType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Recorder",
                table: "InformationRegister_ЦеныНоменклатуры_RecordType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recorder_Type",
                table: "InformationRegister_ЦеныНоменклатуры_RecordType",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
