using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_Base_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипЗапасов = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    РазделУчета = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидДеятельностиНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументДвижения = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументДвижения_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РасчетСебестоимости = table.Column<bool>(type: "bit", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    СуммаВыручки = table.Column<double>(type: "float", nullable: false),
                    СуммаВыручкиБезНДС = table.Column<double>(type: "float", nullable: false),
                    Стоимость = table.Column<double>(type: "float", nullable: false),
                    СтоимостьБезНДС = table.Column<double>(type: "float", nullable: false),
                    ДопРасходы = table.Column<double>(type: "float", nullable: false),
                    ДопРасходыБезНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    СуммаАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаУчетаПартий_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидДеятельностиНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РазделУчета = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ТипЗапасов = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    СуммаВыручки = table.Column<double>(type: "float", nullable: false),
                    СуммаВыручкиБезНДС = table.Column<double>(type: "float", nullable: false),
                    Стоимость = table.Column<double>(type: "float", nullable: false),
                    СтоимостьБезНДС = table.Column<double>(type: "float", nullable: false),
                    ДопРасходы = table.Column<double>(type: "float", nullable: false),
                    ДопРасходыБезНДС = table.Column<double>(type: "float", nullable: false),
                    Трудозатраты = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    СуммаАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_Закупки_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Организация_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ТипЗапасов = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    РасчетСебестоимости = table.Column<bool>(type: "bit", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    СуммаБезНДС = table.Column<double>(type: "float", nullable: false),
                    Стоимость = table.Column<double>(type: "float", nullable: false),
                    СтоимостьБезНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаДопРасходов = table.Column<double>(type: "float", nullable: false),
                    СуммаДопРасходовБезНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаСкидки = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_Закупки_RecordType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВНаличииOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    ВНаличииTurnover = table.Column<double>(type: "float", nullable: false),
                    ВНаличииReceipt = table.Column<double>(type: "float", nullable: false),
                    ВНаличииExpense = table.Column<double>(type: "float", nullable: false),
                    ВНаличииClosingBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ВидыНоменклатуры",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ВидыНоменклатуры", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Номенклатура",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Артикул = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    БазоваяНоменклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидНоменклатуры_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПодвидНоменклатуры_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипНоменклатуры = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВесЧислитель = table.Column<double>(type: "float", nullable: true),
                    ВесЗнаменатель = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Номенклатура", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Партнеры",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    БизнесРегион_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ОсновнойМенеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДатаРегистрации = table.Column<DateTime>(type: "Date", nullable: false),
                    ЮрФизЛицо = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Клиент = table.Column<bool>(type: "bit", nullable: false),
                    Поставщик = table.Column<bool>(type: "bit", nullable: false),
                    Конкурент = table.Column<bool>(type: "bit", nullable: false),
                    ПрочиеОтношения = table.Column<bool>(type: "bit", nullable: false),
                    Перевозчик = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Партнеры", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ПодвидыНоменклатуры",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ПодвидыНоменклатуры", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Пользователи",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Доброга_СхемаПредприятия_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Пользователи", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ПричиныОтменыЗаказовКлиентов",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ПричиныОтменыЗаказовКлиентов", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Склады",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    БизнесРегион_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипСклада = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Склады", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_СхемаПредприятия",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_СхемаПредприятия", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ЗаказКлиента",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Согласован = table.Column<bool>(type: "bit", nullable: false),
                    СкидкиРассчитаны = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказКлиента", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ОтчетОРозничныхПродажах",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ОтчетОРозничныхПродажах", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_РеализацияТоваровУслуг",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РеализацияПоЗаказам = table.Column<bool>(type: "bit", nullable: false),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Согласован = table.Column<bool>(type: "bit", nullable: false),
                    СкидкиРассчитаны = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_РеализацияТоваровУслуг", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "InformationRegister_ЦеныНоменклатуры_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationRegister_ЦеныНоменклатуры_RecordType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Document_ЗаказКлиента_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    СтавкаНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СуммаНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаСНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    СуммаАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Отменено = table.Column<bool>(type: "bit", nullable: false),
                    ПричинаОтмены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КодСтроки = table.Column<int>(type: "int", nullable: false),
                    ДатаОтгрузки = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказКлиента_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ЗаказКлиента_Товары_Document_ЗаказКлиента_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ЗаказКлиента",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_ОтчетОРозничныхПродажах_Товары",
                columns: table => new
                {
                    ИдентификаторСтроки = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    СтавкаНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СуммаНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ОтчетОРозничныхПродажах_Товары", x => x.ИдентификаторСтроки);
                    table.ForeignKey(
                        name: "FK_Document_ОтчетОРозничныхПродажах_Товары_Document_ОтчетОРозничныхПродажах_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ОтчетОРозничныхПродажах",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_РеализацияТоваровУслуг_Товары",
                columns: table => new
                {
                    ИдентификаторСтроки = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СтавкаНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СуммаНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаСНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    СуммаАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КодСтроки = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_РеализацияТоваровУслуг_Товары", x => x.ИдентификаторСтроки);
                    table.ForeignKey(
                        name: "FK_Document_РеализацияТоваровУслуг_Товары_Document_РеализацияТоваровУслуг_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_РеализацияТоваровУслуг",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_ОтчетОРозничныхПродажах_Товары_Ref_Key",
                table: "Document_ОтчетОРозничныхПродажах_Товары",
                column: "Ref_Key");

            migrationBuilder.CreateIndex(
                name: "IX_Document_РеализацияТоваровУслуг_Товары_Ref_Key",
                table: "Document_РеализацияТоваровУслуг_Товары",
                column: "Ref_Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_Закупки_RecordType");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");

            migrationBuilder.DropTable(
                name: "Catalog_ВидыНоменклатуры");

            migrationBuilder.DropTable(
                name: "Catalog_Номенклатура");

            migrationBuilder.DropTable(
                name: "Catalog_Партнеры");

            migrationBuilder.DropTable(
                name: "Catalog_ПодвидыНоменклатуры");

            migrationBuilder.DropTable(
                name: "Catalog_Пользователи");

            migrationBuilder.DropTable(
                name: "Catalog_ПричиныОтменыЗаказовКлиентов");

            migrationBuilder.DropTable(
                name: "Catalog_Склады");

            migrationBuilder.DropTable(
                name: "Catalog_СхемаПредприятия");

            migrationBuilder.DropTable(
                name: "Document_ЗаказКлиента_Товары");

            migrationBuilder.DropTable(
                name: "Document_ОтчетОРозничныхПродажах_Товары");

            migrationBuilder.DropTable(
                name: "Document_РеализацияТоваровУслуг_Товары");

            migrationBuilder.DropTable(
                name: "InformationRegister_ЦеныНоменклатуры_RecordType");

            migrationBuilder.DropTable(
                name: "Document_ЗаказКлиента");

            migrationBuilder.DropTable(
                name: "Document_ОтчетОРозничныхПродажах");

            migrationBuilder.DropTable(
                name: "Document_РеализацияТоваровУслуг");
        }
    }
}
