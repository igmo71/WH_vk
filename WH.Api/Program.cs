using Microsoft.EntityFrameworkCore;
using Quartz;
using Serilog;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using WH.Api.Data;
using WH.Api.DataMining;
using WH.Api.Jobs;
using WH.Api.OData;
using WH.Api.Services;
using WH.Api.Voximplant;

namespace WH.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Регистрация кодировки Windows-1251
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Add services to the container.

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .CreateLogger();
            builder.Host.UseSerilog();

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new ApplicationException("DefaultConnection not found");
            builder.Services.AddDbContextFactory<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString, options =>
                    options.CommandTimeout(180));
                options.EnableSensitiveDataLogging();
            });
            builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // ???

            builder.Services.AddControllers().AddJsonOptions(config =>
            {
                config.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
                config.JsonSerializerOptions.WriteIndented = true;
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddODataClient(builder.Configuration);
            builder.Services.AddODataParameters();
            builder.Services.AddAppServices();
            builder.Services.AddAppJobs(builder.Configuration);
            builder.Services.AddVoximplant(builder.Configuration);
            builder.Services.AddDataMining(builder.Configuration);

            builder.Services.AddWmsODataClient(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseDeveloperExceptionPage();

            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
