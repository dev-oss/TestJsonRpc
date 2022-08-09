using System.Text;
using System.Text.Json;
using TestJsonRpc.Data;

namespace TestJsonRpc.Services
{
    public class OilPricesService : IOilPricesService
    {
        private readonly IEnumerable<OilPriceDto> _prices;

        public OilPricesService()
        {
            _prices =  JsonSerializer.Deserialize<List<OilPriceDto>>(Encoding.UTF8.GetString(Properties.Resources.brent_daily));
        }

        public IEnumerable<OilPriceDto> GetOilPriceTrend(DateTime startDateISO8601, DateTime endDateISO8601)
        {
            return _prices.Where(p => p.Date >= startDateISO8601 && p.Date <= endDateISO8601);
        }
    }
}