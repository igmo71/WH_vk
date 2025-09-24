using Quartz;
using Quartz.AspNetCore;
using Serilog;
using WH.Api.Jobs.AccumulationRegister;
using WH.Api.Jobs.Awesome;
using WH.Api.Jobs.Catalog;
using WH.Api.Jobs.Document;
using WH.Api.Jobs.InformationRegister;

namespace WH.Api.Jobs
{
    public static class JobConfigurationExtensions
    {
        public static IServiceCollection AddAppJobs(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddQuartz(q =>
            {
                // Catalogs
                q.AddJobAndTrigger<CatalogsAllJob>(configuration);

                // Documents
                q.AddJobAndTrigger<DocumentsAllJob>(configuration);

                // InformationRegister 
                q.AddJobAndTrigger<InformationRegisterЦеныНоменклатурыRecordTypeLastTripleMonthJob>(configuration);
                q.AddJobAndTrigger<InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastLastTripleMonthJob>(configuration);
                q.AddJobAndTrigger<InformationRegisterЦеныНоменклатурыПоставкиSliceLastLastTripleMonthJob>(configuration);

                // AccumulationRegister  
                q.AddJobAndTrigger<AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeLastTripleMonthJob>(configuration);
                q.AddJobAndTrigger<AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversLastTripleMonthJob>(configuration);
                //q.AddJobAndTrigger<AccumulationRegisterЗакупкиRecordTypeLastTripleMonthJob>(configuration);
                //q.AddJobAndTrigger<AccumulationRegisterТоварыНаСкладахBalanceLastTripleMonthJob>(configuration);
                q.AddJobAndTrigger<AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversLastTripleMonthJob>(configuration);
                q.AddJobAndTrigger<AccumulationRegisterТоварыНаСкладахRecordTypeLastTripleMonthJob>(configuration);

                // Awesome
                q.AddJobAndTrigger<AwesomeТоварыНаСкладахRecordTypeОперацияЦеныLastTripleMonthJob>(configuration);
            });

            //services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
            services.AddQuartzServer(q => q.WaitForJobsToComplete = true);

            services.AddSingleton<IJobResultService, JobResultService>();

            return services;
        }

        public static void AddJobAndTrigger<TJob>(this IServiceCollectionQuartzConfigurator quartz, IConfiguration configuration)
            where TJob : IJob
        {
            var jobName = typeof(TJob).Name;
            var jobKey = new JobKey(jobName);

            var cronSchedule = configuration[$"Quartz:{jobName}"];
            if (string.IsNullOrEmpty(cronSchedule))
                return;

            quartz.AddJob<TJob>(opts => opts
                .WithIdentity(jobKey));

            quartz.AddTrigger(opts => opts
                .WithIdentity(jobName)
                .ForJob(jobKey)
                .WithCronSchedule(cronSchedule)
            );

            Log.Debug("AddJobAndTrigger {jobName} {cronSchedule}", jobName, cronSchedule);
        }
    }
}
