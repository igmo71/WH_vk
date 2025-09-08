using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_CatalogВидыЦен_CatalogУпаковкиЕдиницыИзмерения : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog_ВидыЦен",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    БазовыйВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Наценка = table.Column<double>(type: "float", nullable: false),
                    СпособЗаданияЦены = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Формула = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ПорогСрабатывания = table.Column<double>(type: "float", nullable: false),
                    Округлять = table.Column<bool>(type: "bit", nullable: false),
                    ВариантОкругления = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ТочностьОкругления = table.Column<double>(type: "float", nullable: false),
                    ОкруглятьВБольшуюСторону = table.Column<bool>(type: "bit", nullable: false),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РеквизитДопУпорядочивания = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    УстанавливатьЦенуПриВводеНаОсновании = table.Column<bool>(type: "bit", nullable: false),
                    ИспользоватьПриПродаже = table.Column<bool>(type: "bit", nullable: false),
                    ИспользоватьПриПередачеМеждуОрганизациями = table.Column<bool>(type: "bit", nullable: false),
                    ИспользоватьПриВыпускеПродукции = table.Column<bool>(type: "bit", nullable: false),
                    ИспользоватьПриПередачеПродукцииДавальцу = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ВидыЦен", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_УпаковкиЕдиницыИзмерения",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Owner_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Вес = table.Column<double>(type: "float", nullable: false),
                    ВесЕдиницаИзмерения_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЕдиницаИзмерения_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Числитель = table.Column<double>(type: "float", nullable: false),
                    Знаменатель = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковок = table.Column<int>(type: "int", nullable: false),
                    ТипУпаковки = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Безразмерная = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_УпаковкиЕдиницыИзмерения", x => x.Ref_Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_ВидыЦен");

            migrationBuilder.DropTable(
                name: "Catalog_УпаковкиЕдиницыИзмерения");
        }
    }
}
