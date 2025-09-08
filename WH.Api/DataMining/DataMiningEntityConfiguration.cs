using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WH.Domain.Models.DataMining;

namespace WH.Api.DataMining
{
    public class DataMiningPredictConfiguration : IEntityTypeConfiguration<Predict>
    {
        public void Configure(EntityTypeBuilder<Predict> builder)
        {
            builder
                .ToTable("DataMining_Predicts")
                .HasKey(e => new { e.WeekNum, e.Склад, e.ВидНоменклатуры_Key, e.ПодвидНоменклатуры_Key });
        }
    }

    public class DataMiningScuSaleRankConfiguration : IEntityTypeConfiguration<ScuSaleRank>
    {
        public void Configure(EntityTypeBuilder<ScuSaleRank> builder)
        {
            builder
                .ToTable("DataMining_ScuSaleRanks")
                .HasKey(e => e.Id);
        }
    }
}
