using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_ScuSaleRanks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DataMining_Predicts",
                table: "DataMining_Predicts");

            migrationBuilder.AlterColumn<string>(
                name: "ПодвидНоменклатуры_Key",
                table: "DataMining_Predicts",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ВидНоменклатуры_Key",
                table: "DataMining_Predicts",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Вес",
                table: "DataMining_Predicts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "НоменклатураВидПодвидKey",
                table: "DataMining_Predicts",
                type: "nvarchar(73)",
                maxLength: 73,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(73)",
                oldMaxLength: 73);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataMining_Predicts",
                table: "DataMining_Predicts",
                columns: new[] { "WeekNum", "Склад", "ВидНоменклатуры_Key", "ПодвидНоменклатуры_Key" });

            migrationBuilder.CreateTable(
                name: "DataMining_ScuSaleRanks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    ВидНоменклатуры = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ПодвидНоменклатуры = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Номенклатура = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ВидНоменклатуры_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПодвидНоменклатуры_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Вес = table.Column<double>(type: "float", nullable: false),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataMining_ScuSaleRanks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataMining_ScuSaleRanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataMining_Predicts",
                table: "DataMining_Predicts");

            migrationBuilder.AlterColumn<string>(
                name: "НоменклатураВидПодвидKey",
                table: "DataMining_Predicts",
                type: "nvarchar(73)",
                maxLength: 73,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(73)",
                oldMaxLength: 73,
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Вес",
                table: "DataMining_Predicts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ПодвидНоменклатуры_Key",
                table: "DataMining_Predicts",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "ВидНоменклатуры_Key",
                table: "DataMining_Predicts",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataMining_Predicts",
                table: "DataMining_Predicts",
                columns: new[] { "WeekNum", "Склад", "НоменклатураВидПодвидKey" });
        }
    }
}
