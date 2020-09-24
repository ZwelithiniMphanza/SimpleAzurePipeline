using System;
using Xunit;
using SimplePipeline.Controllers;

namespace SimplePipeline.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsTemperatureString()
        {
            var temp = controller.Get();
            Assert.Equal("The temperature is 35 degrees celcius", temp.Value);
        }
    }
}
