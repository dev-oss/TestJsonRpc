using TestJsonRpc.Data;

namespace TestJsonRpc.Services
{
    public interface IOilPricesService
    {
        IEnumerable<OilPriceDto> GetOilPriceTrend(DateTime startDateISO8601, DateTime endDateISO8601);
    }
}