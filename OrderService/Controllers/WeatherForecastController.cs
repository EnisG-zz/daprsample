using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapr.Client;
using Dapr.Client.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DaprClient _client;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DaprClient client)
        {
            _logger = logger;
            _client = client;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _client.InvokeMethodAsync<IEnumerable<WeatherForecast>>("inventoryservice", "WeatherForecast", new HTTPExtension { Verb = HTTPVerb.Get });
        }
    }
}
