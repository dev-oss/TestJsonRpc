using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestJsonRpc.Data;

namespace TestJsonRpc.Services
{
    public interface IOilPricesService
    {
        IEnumerable<OilPriceDto> GetOilPriceTrend(DateTime startDateISO8601, DateTime endDateISO8601);
    }
}
