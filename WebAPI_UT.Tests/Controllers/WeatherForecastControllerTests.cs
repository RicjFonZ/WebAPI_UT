using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace WebAPI_UT.Tests.Controllers
{
    internal class WeatherForecastControllerTests
    {

        private WeatherForecastController _weatherForecastController;
        private Mock<ILogger<WeatherForecastController>> logger;



        [SetUp]
        public void Setup()
        {
            logger = new Mock<ILogger<WeatherForecastController>>();
            _weatherForecastController = new WeatherForecastController(logger.Object);
        }

        [Test]
        public void Test1()
        {
            var k = _weatherForecastController.Get();

            
        }
    }
}
