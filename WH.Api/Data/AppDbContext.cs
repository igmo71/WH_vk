using Microsoft.EntityFrameworkCore;
using WH.Api.Jobs;
using WH.Domain.Models;
using WH.Domain.Models.AccumulationRegister;
using WH.Domain.Models.Awesome;
using WH.Domain.Models.Catalog;
using WH.Domain.Models.Document;
using WH.Domain.Models.InformationRegister;

namespace WH.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<JobResult> JobResults { get; set; }

        // AccumulationRegister
        public DbSet<AccumulationRegisterВыручкаИСебестоимостьПродажRecordType> AccumulationRegisterВыручкаИСебестоимостьПродажRecordType { get; set; }
        public DbSet<AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers> AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers { get; set; }
        public DbSet<AccumulationRegisterГрафикПоступленияТоваровRecordType> AccumulationRegisterГрафикПоступленияТоваровRecordType { get; set; }
        public DbSet<AccumulationRegisterЗакупкиRecordType> AccumulationRegisterЗакупкиRecordType { get; set; }

        public DbSet<AccumulationRegisterТоварыНаСкладахBalance> AccumulationRegisterТоварыНаСкладахBalance { get; set; }
        public DbSet<AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers> AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers { get; set; }

        public DbSet<AccumulationRegisterТоварыНаСкладахRecordType> AccumulationRegisterТоварыНаСкладахRecordType { get; set; }

        // Catalog
        public DbSet<CatalogБизнесРегионы> CatalogБизнесРегионы { get; set; }
        public DbSet<CatalogГруппыПользователей> CatalogГруппыПользователей { get; set; }
        public DbSet<CatalogГруппыПользователейСостав> CatalogГруппыПользователейСостав { get; set; }
        public DbSet<CatalogВидыНоменклатуры> CatalogВидыНоменклатуры { get; set; }
        public DbSet<CatalogВидыЦен> CatalogВидыЦен { get; set; }
        public DbSet<CatalogЗначенияСвойствОбъектов> CatalogЗначенияСвойствОбъектов { get; set; }
        public DbSet<CatalogМарки> CatalogМарки { get; set; }
        public DbSet<CatalogНоменклатура> CatalogНоменклатура { get; set; }
        public DbSet<CatalogПартнеры> CatalogПартнеры { get; set; }
        public DbSet<CatalogПартнерыВидыДеятельности> CatalogПартнерыВидыДеятельности { get; set; }
        public DbSet<CatalogПартнерыДополнительныеРеквизиты> CatalogПартнерыДополнительныеРеквизиты { get; set; }
        public DbSet<CatalogПартнерыVip> CatalogПартнерыVip { get; set; }
        public DbSet<CatalogПодвидыНоменклатуры> CatalogПодвидыНоменклатуры { get; set; }
        public DbSet<CatalogПользователи> CatalogПользователи { get; set; }
        public DbSet<CatalogПричиныОтменыЗаказовКлиентов> CatalogПричиныОтменыЗаказовКлиентов { get; set; }
        public DbSet<CatalogПроизводители> CatalogПроизводители { get; set; }
        public DbSet<CatalogСклады> CatalogСклады { get; set; }
        public DbSet<CatalogСоглашенияСКлиентами> CatalogСоглашенияСКлиентами { get; set; }
        public DbSet<CatalogСтруктураПредприятия> CatalogСтруктураПредприятия { get; set; }
        public DbSet<CatalogУпаковкиЕдиницыИзмерения> CatalogУпаковкиЕдиницыИзмерения { get; set; }
        public DbSet<CatalogЦеновыеГруппы> CatalogЦеновыеГруппы { get; set; }

        // Document
        public DbSet<DocumentАктОРасхожденияхПослеОтгрузки> DocumentАктОРасхожденияхПослеОтгрузки { get; set; }
        public DbSet<DocumentАктОРасхожденияхПослеОтгрузкиТовары> DocumentАктОРасхожденияхПослеОтгрузкиТовары { get; set; }

        public DbSet<DocumentВозвратТоваровОтКлиента> DocumentВозвратТоваровОтКлиента { get; set; }
        public DbSet<DocumentВозвратТоваровОтКлиентаТовары> DocumentВозвратТоваровОтКлиентаТовары { get; set; }

        public DbSet<DocumentЗаказКлиента> DocumentЗаказКлиента { get; set; }
        public DbSet<DocumentЗаказКлиентаТовары> DocumentЗаказКлиентаТовары { get; set; }

        public DbSet<DocumentЗаказНаПеремещение> DocumentЗаказНаПеремещение { get; set; }
        public DbSet<DocumentЗаказНаПеремещениеТовары> DocumentЗаказНаПеремещениеТовары { get; set; }

        public DbSet<DocumentОприходованиеИзлишковТоваров> DocumentОприходованиеИзлишковТоваров { get; set; }
        public DbSet<DocumentОприходованиеИзлишковТоваровТовары> DocumentОприходованиеИзлишковТоваровТовары { get; set; }

        public DbSet<DocumentОтчетОРозничныхПродажах> DocumentОтчетОРозничныхПродажах { get; set; }
        public DbSet<DocumentОтчетОРозничныхПродажахТовары> DocumentОтчетОРозничныхПродажахТовары { get; set; }

        public DbSet<DocumentПриобретениеТоваровУслуг> DocumentПриобретениеТоваровУслуг { get; set; }
        public DbSet<DocumentПриобретениеТоваровУслугТовары> DocumentПриобретениеТоваровУслугТовары { get; set; }

        public DbSet<DocumentПриходныйОрдерНаТовары> DocumentПриходныйОрдерНаТовары { get; set; }
        public DbSet<DocumentРасходныйОрдерНаТовары> DocumentРасходныйОрдерНаТовары { get; set; }

        public DbSet<DocumentРеализацияТоваровУслуг> DocumentРеализацияТоваровУслуг { get; set; }
        public DbSet<DocumentРеализацияТоваровУслугТовары> DocumentРеализацияТоваровУслугТовары { get; set; }

        public DbSet<DocumentСборкаТоваров> DocumentСборкаТоваров { get; set; }
        public DbSet<DocumentСборкаТоваровТовары> DocumentСборкаТоваровТовары { get; set; }

        public DbSet<DocumentУстановкаЦенНоменклатуры> DocumentУстановкаЦенНоменклатуры { get; set; }
        public DbSet<DocumentУстановкаЦенНоменклатурыТовары> DocumentУстановкаЦенНоменклатурыТовары { get; set; }


        // InformationRegister 
        public DbSet<InformationRegisterЦеныНоменклатурыRecordType> InformationRegisterЦеныНоменклатурыRecordType { get; set; }
        //Закупочная Доброга
        public DbSet<InformationRegisterЦеныНоменклатурыЗакупочныеSliceLast> InformationRegisterЦеныНоменклатурыЗакупочныеSliceLast { get; set; }
        // Закупочная ВоронежКреп
        public DbSet<InformationRegisterЦеныНоменклатурыПоставкиSliceLast> InformationRegisterЦеныНоменклатурыПоставкиSliceLast { get; set; }
        
        // Awesome
        public DbSet<VТоварыНаСкладахBalanceAndTurnoversNoWhs> VТоварыНаСкладахBalanceAndTurnoversNoWhs { get; set; }
        public DbSet<VТоварыНаСкладахRecordTypeОперацияЦеныOp> VТоварыНаСкладахRecordTypeОперацияЦеныOp { get; set; }
        public DbSet<AwesomeТоварыНаСкладахRecordTypeОперацияЦены> AwesomeТоварыНаСкладахRecordTypeОперацияЦены { get; set; }


        public DbSet<CurrencyRate> CurrencyRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobResult>().ToTable("LoadingJobResults").HasKey(e => e.Id);


            // AccumulationRegister
            modelBuilder.Entity<AccumulationRegisterВыручкаИСебестоимостьПродажRecordType>().ToTable("AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType").HasKey(e => e.Id);
            modelBuilder.Entity<AccumulationRegisterВыручкаИСебестоимостьПродажTurnovers>().ToTable("AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers").HasKey(e => e.Id);
            modelBuilder.Entity<AccumulationRegisterГрафикПоступленияТоваровRecordType>().ToTable("AccumulationRegister_ГрафикПоступленияТоваров_RecordType").HasKey(e => e.Id);
            modelBuilder.Entity<AccumulationRegisterЗакупкиRecordType>().ToTable("AccumulationRegister_Закупки_RecordType").HasKey(e => e.Id);
            modelBuilder.Entity<AccumulationRegisterТоварыНаСкладахBalance>().ToTable("AccumulationRegister_ТоварыНаСкладах_Balance").HasKey(e => e.Id);
            modelBuilder.Entity<AccumulationRegisterТоварыНаСкладахBalanceAndTurnovers>().ToTable("AccumulationRegister_ТоварыНаСкладах_BalanceAndTurnovers").HasKey(e => e.Id);
            modelBuilder.Entity<AccumulationRegisterТоварыНаСкладахRecordType>().ToTable("AccumulationRegister_ТоварыНаСкладах_RecordType").HasKey(e => e.Id);

            // Catalog
            modelBuilder.Entity<CatalogБизнесРегионы>().ToTable("Catalog_БизнесРегионы").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogГруппыПользователей>().ToTable("Catalog_ГруппыПользователей").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogГруппыПользователей>().HasMany(e => e.Состав).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CatalogГруппыПользователейСостав>().ToTable("Catalog_ГруппыПользователей_Состав").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<CatalogВидыНоменклатуры>().ToTable("Catalog_ВидыНоменклатуры").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogВидыЦен>().ToTable("Catalog_ВидыЦен").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogЗначенияСвойствОбъектов>().ToTable("Catalog_ЗначенияСвойствОбъектов").HasKey(e => e.Ref_Key);

            modelBuilder.Entity<CatalogМарки>().ToTable("Catalog_Марки").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogНоменклатура>().ToTable("Catalog_Номенклатура").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПартнеры>().ToTable("Catalog_Партнеры").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПартнерыВидыДеятельности>().ToTable("Catalog_Партнеры_ВидыДеятельности").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<CatalogПартнерыДополнительныеРеквизиты>().ToTable("Catalog_Партнеры_ДополнительныеРеквизиты").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<CatalogПартнерыVip>().ToTable("Catalog_Партнеры_Vip").HasKey(e => e.Партнер_Key);
            modelBuilder.Entity<CatalogПодвидыНоменклатуры>().ToTable("Catalog_ПодвидыНоменклатуры").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПользователи>().ToTable("Catalog_Пользователи").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПричиныОтменыЗаказовКлиентов>().ToTable("Catalog_ПричиныОтменыЗаказовКлиентов").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogПроизводители>().ToTable("Catalog_Производители").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogСклады>().ToTable("Catalog_Склады").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogСоглашенияСКлиентами>().ToTable("Catalog_СоглашенияСКлиентами").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogСтруктураПредприятия>().ToTable("Catalog_СтруктураПредприятия").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogУпаковкиЕдиницыИзмерения>().ToTable("Catalog_УпаковкиЕдиницыИзмерения").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<CatalogЦеновыеГруппы>().ToTable("Catalog_ЦеновыеГруппы").HasKey(e => e.Ref_Key);

            // Document
            modelBuilder.Entity<DocumentАктОРасхожденияхПослеОтгрузки>().ToTable("Document_АктОРасхожденияхПослеОтгрузки").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentАктОРасхожденияхПослеОтгрузкиТовары>().ToTable("Document_АктОРасхожденияхПослеОтгрузки_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentАктОРасхожденияхПослеОтгрузки>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentВозвратТоваровОтКлиента>().ToTable("Document_ВозвратТоваровОтКлиента").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentВозвратТоваровОтКлиентаТовары>().ToTable("Document_ВозвратТоваровОтКлиента_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentВозвратТоваровОтКлиента>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentЗаказКлиента>().ToTable("Document_ЗаказКлиента").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentЗаказКлиентаТовары>().ToTable("Document_ЗаказКлиента_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentЗаказКлиента>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentЗаказНаПеремещение>().ToTable("Document_ЗаказНаПеремещение").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentЗаказНаПеремещениеТовары>().ToTable("Document_ЗаказНаПеремещение_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentЗаказНаПеремещение>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentОприходованиеИзлишковТоваров>().ToTable("Document_ОприходованиеИзлишковТоваров").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentОприходованиеИзлишковТоваровТовары>().ToTable("Document_ОприходованиеИзлишковТоваров_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentОприходованиеИзлишковТоваров>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentОтчетОРозничныхПродажах>().ToTable("Document_ОтчетОРозничныхПродажах").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentОтчетОРозничныхПродажахТовары>().ToTable("Document_ОтчетОРозничныхПродажах_Товары").HasKey(e => e.ИдентификаторСтроки);
            modelBuilder.Entity<DocumentОтчетОРозничныхПродажах>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentПриобретениеТоваровУслуг>().ToTable("Document_ПриобретениеТоваровУслуг").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentПриобретениеТоваровУслугТовары>().ToTable("Document_ПриобретениеТоваровУслуг_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentПриобретениеТоваровУслуг>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentПриходныйОрдерНаТовары>().ToTable("Document_ПриходныйОрдерНаТовары").HasKey(e => e.Ref_Key);

            modelBuilder.Entity<DocumentРасходныйОрдерНаТовары>().ToTable("Document_РасходныйОрдерНаТовары").HasKey(e => e.Ref_Key);

            modelBuilder.Entity<DocumentРеализацияТоваровУслуг>().ToTable("Document_РеализацияТоваровУслуг").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentРеализацияТоваровУслугТовары>().ToTable("Document_РеализацияТоваровУслуг_Товары").HasKey(e => e.ИдентификаторСтроки);
            modelBuilder.Entity<DocumentРеализацияТоваровУслуг>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentСборкаТоваров>().ToTable("Document_СборкаТоваров").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentСборкаТоваровТовары>().ToTable("Document_СборкаТоваров_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentСборкаТоваров>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DocumentУстановкаЦенНоменклатуры>().ToTable("Document_УстановкаЦенНоменклатуры").HasKey(e => e.Ref_Key);
            modelBuilder.Entity<DocumentУстановкаЦенНоменклатурыТовары>().ToTable("Document_УстановкаЦенНоменклатуры_Товары").HasKey(e => new { e.Ref_Key, e.LineNumber });
            modelBuilder.Entity<DocumentУстановкаЦенНоменклатуры>().HasMany(e => e.Товары).WithOne().HasForeignKey(e => e.Ref_Key).HasPrincipalKey(e => e.Ref_Key).OnDelete(DeleteBehavior.Cascade);


            // InformationRegister
            modelBuilder.Entity<InformationRegisterЦеныНоменклатурыRecordType>().ToTable("InformationRegister_ЦеныНоменклатуры_RecordType").HasKey(e => e.Id);
            modelBuilder.Entity<InformationRegisterЦеныНоменклатурыЗакупочныеSliceLast>().ToTable("InformationRegister_ЦеныНоменклатуры_Закупочные_SliceLast").HasKey(e => e.Id);
            modelBuilder.Entity<InformationRegisterЦеныНоменклатурыПоставкиSliceLast>().ToTable("InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast").HasKey(e => e.Id);

            // Awesome
            modelBuilder.Entity<VТоварыНаСкладахBalanceAndTurnoversNoWhs>().ToView("v_ТоварыНаСкладах_BalanceAndTurnovers_no_whs").HasNoKey();
            modelBuilder.Entity<VТоварыНаСкладахRecordTypeОперацияЦеныOp>().ToView("v_ТоварыНаСкладах_RecordType_Операция_Цены_op").HasNoKey();
            modelBuilder.Entity<AwesomeТоварыНаСкладахRecordTypeОперацияЦены>().ToTable("Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены").HasKey(e => e.Id);
        }
    }
}
