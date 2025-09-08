
namespace WH.Api.Services.InformationRegister
{
    public abstract class InformationRegisterService : IInformationRegisterService
    {
        public Task<int> DeleteRangeAsync(DateTime begin, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult> GetODataAndDbCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult> LoadingAsync()
        {
            throw new NotImplementedException();
        }
    }
}
