using Microsoft.EntityFrameworkCore;
using WH.Api.Data;

namespace WH.Api.Jobs
{
    public interface IJobResultService
    {
        Task SetBeginAsync(string entityName);
        Task SetEndAsync(string entityName);

    }

    public class JobResultService(IDbContextFactory<AppDbContext> dbContextFactory) : IJobResultService
    {
        protected readonly IDbContextFactory<AppDbContext> _dbContextFactory = dbContextFactory;

        public async Task SetBeginAsync(string entityName)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            if (await dbContext.JobResults.AnyAsync(e => e.Name == entityName))
            {
                await dbContext.JobResults.Where(e => e.Name == entityName)
                    .ExecuteUpdateAsync(setters => setters
                        .SetProperty(e => e.Begin, DateTime.Now)
                        .SetProperty(e => e.Success, false));
            }
            else
            {
                await dbContext.JobResults.AddAsync(
                    new JobResult
                    {
                        Name = entityName,
                        Success = false,
                        Begin = DateTime.Today
                    });
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task SetEndAsync(string entityName)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            await dbContext.JobResults.Where(e => e.Name == entityName)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(e => e.End, DateTime.Now)
                    .SetProperty(e => e.Success, true));
        }
    }
}
