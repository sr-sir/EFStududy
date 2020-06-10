using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFStudy.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EFStudy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MysqlDbContext _mysqlDbContext;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, MysqlDbContext mysqlDbContext)
        {
            _logger = logger;
            _mysqlDbContext = mysqlDbContext;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}


        [HttpGet]
        public string Get()
        {
            //string str = "11111";
            _mysqlDbContext.addresses.Add(new Models.address
            {
                province = "上海",
                city = "嘉定区"
            });
            _mysqlDbContext.SaveChanges();
            string str = JsonConvert.SerializeObject(_mysqlDbContext.addresses.ToList());
            return str;
        }
    }
}
