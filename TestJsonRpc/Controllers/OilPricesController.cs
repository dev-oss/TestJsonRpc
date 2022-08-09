using EdjCase.JsonRpc.Router;
using EdjCase.JsonRpc.Router.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestJsonRpc.Services;

namespace TestJsonRpc.Controllers
{
    public class OilPricesController : RpcController
    {
        private readonly IOilPricesService _service;

        public OilPricesController(IOilPricesService service)
        {
            _service = service;
        }

        public IRpcMethodResult GetOilPriceTrend(DateTime startDateISO8601, DateTime endDateISO8601)
        {
            return this.Ok(new { Prices = _service.GetOilPriceTrend(startDateISO8601, endDateISO8601) });
        }
    }
}
