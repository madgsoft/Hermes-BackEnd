using System;
using Hermes_Backend.Services;
using Xunit;

namespace Hermes_Backend.Tests
{
    public class WeatherServiceTests
    {
        private readonly WeatherService _weatherService;

        public WeatherServiceTests()
        {
            _weatherService = new WeatherService();
        }

        [Fact]
        public void GetWeatherForecasts_ShouldReturnCorrectNumberOfDays()
        {
            // Arrange
            int days = 5;

            // Act
            var result = _weatherService.GetWeatherForecasts(days);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(days, result.Length);
        }

        [Fact]
        public void GetWeatherForecasts_ShouldReturnValidTemperatureRange()
        {
            // Act
            var result = _weatherService.GetWeatherForecasts(5);

            // Assert
            foreach (var forecast in result)
            {
                Assert.InRange(forecast.TemperatureC, -20, 55);
            }
        }

        [Fact]
        public void GetWeatherForecasts_ShouldThrowException_WhenDaysIsNegative()
        {
            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _weatherService.GetWeatherForecasts(-1));
        }
    }
}
