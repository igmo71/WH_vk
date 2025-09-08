namespace WH.Api.Services
{
    public interface IAppService { }

    public interface ILoadingService : IAppService
    {
        Task<ServiceResult> LoadingAsync();
    }

    public interface ILoadingByDateService : IAppService
    {
        Task<ServiceResult> LoadingAsync(DateTime begin, DateTime end);
        Task<ServiceResult> LoadingAsync(int year, int month);
        Task<ServiceResult> LoadingAsync(int lastDays);
        Task<ServiceResult> LoadingCurrentMonthAsync();
        Task<ServiceResult> LoadingPreviousMonthAsync();
        Task<List<ServiceResult>> LoadingLastPairMonthsAsync();
        Task<List<ServiceResult>> LoadingLastTripleMonthsAsync();
    }

    public interface IGetODataAndDbCount
    {
        Task<ServiceResult> GetODataAndDbCountAsync();
    }

    public interface IGetODataAndDbCountByDate
    {
        Task<ServiceResult> GetODataAndDbCountAsync(DateTime begin, DateTime end);
    }

    public interface IDeleteAll
    {
        Task<int> DeleteAllAsync();
    }

    public interface IDeleteRange
    {
        Task<int> DeleteRangeAsync(DateTime begin, DateTime end);
    }

    public interface ICatalogService : ILoadingService, IGetODataAndDbCount, IDeleteAll
    { }

    public interface IDocumentService : ILoadingByDateService, IGetODataAndDbCountByDate, IDeleteRange
    { }

    public interface IAccumulationRegisterService : ILoadingByDateService, IGetODataAndDbCountByDate, IDeleteRange
    { }

    public interface IInformationRegisterService : ILoadingService, IGetODataAndDbCount, IDeleteRange
    { }

    public interface IInformationRegisterPeriodicService : ILoadingByDateService, IGetODataAndDbCountByDate, IDeleteRange
    { }
}
