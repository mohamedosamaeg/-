using CpactyTaxi.View_Models;

namespace CpactyTaxi.Interfaces
{
    public interface IRideInfoRepository
    {
        Task<TaxiResultDto> GetTaxiResult();
        Task<string> AccessToken();
    }
}
