using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
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
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Соглашение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументДвижения = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументДвижения_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипЗапасов = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РазделУчета = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидДеятельностиНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    СуммаВыручки = table.Column<double>(type: "float", nullable: false),
                    СуммаВыручкиБезНДС = table.Column<double>(type: "float", nullable: false),
                    Стоимость = table.Column<double>(type: "float", nullable: false),
                    СтоимостьБезНДС = table.Column<double>(type: "float", nullable: false),
                    ДопРасходы = table.Column<double>(type: "float", nullable: false),
                    ДопРасходыБезНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    СуммаАвтоматическойСкидки = table.Column<double>(type: "float", nullable: false),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РасчетСебестоимости = table.Column<bool>(type: "bit", nullable: false),
                    РасчетПартий = table.Column<bool>(type: "bit", nullable: false),
                    РасчетНеЗавершен = table.Column<bool>(type: "bit", nullable: false)
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
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Соглашение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипЗапасов = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РазделУчета = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидДеятельностиНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                name: "AccumulationRegister_ГрафикПоступленияТоваров_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДатаСобытия = table.Column<DateTime>(type: "Date", nullable: false),
                    КоличествоИзЗаказов = table.Column<double>(type: "float", nullable: false),
                    КоличествоПодЗаказ = table.Column<double>(type: "float", nullable: false),
                    КоличествоИзЗаказовСНеподтвержденными = table.Column<double>(type: "float", nullable: false),
                    КоличествоПодЗаказСНеподтвержденными = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ГрафикПоступленияТоваров_RecordType", x => x.Id);
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
                name: "AccumulationRegister_ТоварыНаСкладах_Balance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВНаличииBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ТоварыНаСкладах_Balance", x => x.Id);
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
                    ВНаличииClosingBalance = table.Column<double>(type: "float", nullable: false),
                    КОтгрузкеOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    КОтгрузкеTurnover = table.Column<double>(type: "float", nullable: false),
                    КОтгрузкеReceipt = table.Column<double>(type: "float", nullable: false),
                    КОтгрузкеExpense = table.Column<double>(type: "float", nullable: false),
                    КОтгрузкеClosingBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_ТоварыНаСкладах_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Назначение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВНаличии = table.Column<double>(type: "float", nullable: false),
                    КОтгрузке = table.Column<double>(type: "float", nullable: false),
                    КонтролироватьОстатки = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ТоварыНаСкладах_RecordType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Операция = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    RecordType = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВНаличии = table.Column<double>(type: "float", nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: true),
                    ЦенаЗакупки = table.Column<double>(type: "float", nullable: true),
                    ЦенаПродажи = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_БизнесРегионы",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_БизнесРегионы", x => x.Ref_Key);
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
                name: "Catalog_ВидыЦен",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Идентификатор = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
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
                    РеквизитДопУпорядочивания = table.Column<int>(type: "int", nullable: false),
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
                name: "Catalog_ГруппыПользователей",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Комментарий = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ГруппыПользователей", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ЗначенияСвойствОбъектов",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Owner_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ЗначенияСвойствОбъектов", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Марки",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Производитель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Марки", x => x.Ref_Key);
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
                    ТипУпаковки_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипНоменклатуры = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Производитель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Марка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЦеноваяГруппа_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
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
                name: "Catalog_Партнеры_ВидыДеятельности",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    ВидДеятельности_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Партнеры_ВидыДеятельности", x => new { x.Ref_Key, x.LineNumber });
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Партнеры_ДополнительныеРеквизиты",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Свойство_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Значение = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Партнеры_ДополнительныеРеквизиты", x => new { x.Ref_Key, x.LineNumber });
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Партнеры_Vip",
                columns: table => new
                {
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Партнеры_Vip", x => x.Партнер_Key);
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
                    Доброга_СхемаПредприятия_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Должность = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
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
                name: "Catalog_Производители",
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
                    table.PrimaryKey("PK_Catalog_Производители", x => x.Ref_Key);
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
                name: "Catalog_СоглашенияСКлиентами",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Номер = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Соглашение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_СоглашенияСКлиентами", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_СтруктураПредприятия",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_СтруктураПредприятия", x => x.Ref_Key);
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

            migrationBuilder.CreateTable(
                name: "Catalog_ЦеновыеГруппы",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ЦеновыеГруппы", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    МассаБруттоПоФакту = table.Column<double>(type: "float", nullable: false),
                    МассаНеттоПоФакту = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_АктОРасхожденияхПослеОтгрузки", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ВозвратТоваровОтКлиента",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ПричинаВозврата = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ВозвратТоваровОтКлиента", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ЗаказКлиента",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Согласован = table.Column<bool>(type: "bit", nullable: false),
                    СкидкиРассчитаны = table.Column<bool>(type: "bit", nullable: false),
                    ИсточникЗаявки_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказКлиента", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ЗаказНаПеремещение",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Организация_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ОрганизацияПолучатель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладОтправитель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладПолучатель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументОснование = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументОснование_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказНаПеремещение", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ОприходованиеИзлишковТоваров",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПересчетТоваров_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Основание = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Основание_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ОприходованиеИзлишковТоваров", x => x.Ref_Key);
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
                name: "Document_ПриобретениеТоваровУслуг",
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
                    ЗаказПоставщику_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПоступлениеПоЗаказам = table.Column<bool>(type: "bit", nullable: false),
                    Валюта_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Согласован = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ПриобретениеТоваровУслуг", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ПриходныйОрдерНаТовары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладскаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Отправитель = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Отправитель_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВсегоМест = table.Column<int>(type: "int", nullable: false),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Распоряжение = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Распоряжение_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ПриходныйОрдерНаТовары", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_РасходныйОрдерНаТовары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладскаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Получатель = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Получатель_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВсегоМест = table.Column<int>(type: "int", nullable: false),
                    ДатаОтгрузки = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_РасходныйОрдерНаТовары", x => x.Ref_Key);
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
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РеализацияПоЗаказам = table.Column<bool>(type: "bit", nullable: false),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Согласован = table.Column<bool>(type: "bit", nullable: false),
                    СкидкиРассчитаны = table.Column<bool>(type: "bit", nullable: false),
                    ИсточникЗаявки_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_РеализацияТоваровУслуг", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_СборкаТоваров",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    ЗаказНаСборку_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СборкаПодДеятельность = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВариантПриемкиТоваров = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВариантКомплектации_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    НоменклатураОсновногоКомпонента_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_СборкаТоваров", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_УстановкаЦенНоменклатуры",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Согласован = table.Column<bool>(type: "bit", nullable: false),
                    ДокументОснование = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументОснование_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_УстановкаЦенНоменклатуры", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "InformationRegister_ЦеныНоменклатуры_Закупочные_SliceLast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Period = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationRegister_ЦеныНоменклатуры_Закупочные_SliceLast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Period = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationRegister_ЦеныНоменклатуры_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "LoadingJobResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Begin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Success = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadingJobResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ГруппыПользователей_Состав",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Пользователь_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ГруппыПользователей_Состав", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Catalog_ГруппыПользователей_Состав_Catalog_ГруппыПользователей_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Catalog_ГруппыПользователей",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Реализация = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Реализация_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковокПоДокументу = table.Column<double>(type: "float", nullable: false),
                    КоличествоПоДокументу = table.Column<double>(type: "float", nullable: false),
                    СуммаПоДокументу = table.Column<double>(type: "float", nullable: false),
                    ЗаполненоПоРеализации = table.Column<bool>(type: "bit", nullable: false),
                    ПричинаРасхожденияKey = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_АктОРасхожденияхПослеОтгрузки_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_АктОРасхожденияхПослеОтгрузки_Товары_Document_АктОРасхожденияхПослеОтгрузки_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_АктОРасхожденияхПослеОтгрузки",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_ВозвратТоваровОтКлиента_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    ПричинаВозвратаKey = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ВозвратТоваровОтКлиента_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ВозвратТоваровОтКлиента_Товары_Document_ВозвратТоваровОтКлиента_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ВозвратТоваровОтКлиента",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Document_ЗаказНаПеремещение_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Отменено = table.Column<bool>(type: "bit", nullable: false),
                    КодСтроки = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗНП_Комментарий = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ЗНП_ПричинаОтмены_Key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказНаПеремещение_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ЗаказНаПеремещение_Товары_Document_ЗаказНаПеремещение_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ЗаказНаПеремещение",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_ОприходованиеИзлишковТоваров_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ОприходованиеИзлишковТоваров_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ОприходованиеИзлишковТоваров_Товары_Document_ОприходованиеИзлишковТоваров_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ОприходованиеИзлишковТоваров",
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
                name: "Document_ПриобретениеТоваровУслуг_Товары",
                columns: table => new
                {
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
                    СуммаСНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказПоставщику_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ПриобретениеТоваровУслуг_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ПриобретениеТоваровУслуг_Товары_Document_ПриобретениеТоваровУслуг_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ПриобретениеТоваровУслуг",
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

            migrationBuilder.CreateTable(
                name: "Document_СборкаТоваров_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    ДоляСтоимости = table.Column<double>(type: "float", nullable: false),
                    КодСтроки = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_СборкаТоваров_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_СборкаТоваров_Товары_Document_СборкаТоваров_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_СборкаТоваров",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_УстановкаЦенНоменклатуры_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    ЦенаИзмененаВручную = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_УстановкаЦенНоменклатуры_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_УстановкаЦенНоменклатуры_Товары_Document_УстановкаЦенНоменклатуры_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_УстановкаЦенНоменклатуры",
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
                name: "AccumulationRegister_ГрафикПоступленияТоваров_RecordType");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_Закупки_RecordType");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_ТоварыНаСкладах_Balance");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_ТоварыНаСкладах_RecordType");

            migrationBuilder.DropTable(
                name: "Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены");

            migrationBuilder.DropTable(
                name: "Catalog_БизнесРегионы");

            migrationBuilder.DropTable(
                name: "Catalog_ВидыНоменклатуры");

            migrationBuilder.DropTable(
                name: "Catalog_ВидыЦен");

            migrationBuilder.DropTable(
                name: "Catalog_ГруппыПользователей_Состав");

            migrationBuilder.DropTable(
                name: "Catalog_ЗначенияСвойствОбъектов");

            migrationBuilder.DropTable(
                name: "Catalog_Марки");

            migrationBuilder.DropTable(
                name: "Catalog_Номенклатура");

            migrationBuilder.DropTable(
                name: "Catalog_Партнеры");

            migrationBuilder.DropTable(
                name: "Catalog_Партнеры_ВидыДеятельности");

            migrationBuilder.DropTable(
                name: "Catalog_Партнеры_ДополнительныеРеквизиты");

            migrationBuilder.DropTable(
                name: "Catalog_Партнеры_Vip");

            migrationBuilder.DropTable(
                name: "Catalog_ПодвидыНоменклатуры");

            migrationBuilder.DropTable(
                name: "Catalog_Пользователи");

            migrationBuilder.DropTable(
                name: "Catalog_ПричиныОтменыЗаказовКлиентов");

            migrationBuilder.DropTable(
                name: "Catalog_Производители");

            migrationBuilder.DropTable(
                name: "Catalog_Склады");

            migrationBuilder.DropTable(
                name: "Catalog_СоглашенияСКлиентами");

            migrationBuilder.DropTable(
                name: "Catalog_СтруктураПредприятия");

            migrationBuilder.DropTable(
                name: "Catalog_УпаковкиЕдиницыИзмерения");

            migrationBuilder.DropTable(
                name: "Catalog_ЦеновыеГруппы");

            migrationBuilder.DropTable(
                name: "CurrencyRates");

            migrationBuilder.DropTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки_Товары");

            migrationBuilder.DropTable(
                name: "Document_ВозвратТоваровОтКлиента_Товары");

            migrationBuilder.DropTable(
                name: "Document_ЗаказКлиента_Товары");

            migrationBuilder.DropTable(
                name: "Document_ЗаказНаПеремещение_Товары");

            migrationBuilder.DropTable(
                name: "Document_ОприходованиеИзлишковТоваров_Товары");

            migrationBuilder.DropTable(
                name: "Document_ОтчетОРозничныхПродажах_Товары");

            migrationBuilder.DropTable(
                name: "Document_ПриобретениеТоваровУслуг_Товары");

            migrationBuilder.DropTable(
                name: "Document_ПриходныйОрдерНаТовары");

            migrationBuilder.DropTable(
                name: "Document_РасходныйОрдерНаТовары");

            migrationBuilder.DropTable(
                name: "Document_РеализацияТоваровУслуг_Товары");

            migrationBuilder.DropTable(
                name: "Document_СборкаТоваров_Товары");

            migrationBuilder.DropTable(
                name: "Document_УстановкаЦенНоменклатуры_Товары");

            migrationBuilder.DropTable(
                name: "InformationRegister_ЦеныНоменклатуры_Закупочные_SliceLast");

            migrationBuilder.DropTable(
                name: "InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast");

            migrationBuilder.DropTable(
                name: "InformationRegister_ЦеныНоменклатуры_RecordType");

            migrationBuilder.DropTable(
                name: "LoadingJobResults");

            migrationBuilder.DropTable(
                name: "Catalog_ГруппыПользователей");

            migrationBuilder.DropTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки");

            migrationBuilder.DropTable(
                name: "Document_ВозвратТоваровОтКлиента");

            migrationBuilder.DropTable(
                name: "Document_ЗаказКлиента");

            migrationBuilder.DropTable(
                name: "Document_ЗаказНаПеремещение");

            migrationBuilder.DropTable(
                name: "Document_ОприходованиеИзлишковТоваров");

            migrationBuilder.DropTable(
                name: "Document_ОтчетОРозничныхПродажах");

            migrationBuilder.DropTable(
                name: "Document_ПриобретениеТоваровУслуг");

            migrationBuilder.DropTable(
                name: "Document_РеализацияТоваровУслуг");

            migrationBuilder.DropTable(
                name: "Document_СборкаТоваров");

            migrationBuilder.DropTable(
                name: "Document_УстановкаЦенНоменклатуры");
        }
    }
}
