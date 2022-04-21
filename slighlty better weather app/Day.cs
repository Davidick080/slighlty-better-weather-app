using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLWeather
{
    public class Day
    {
        public string date,city,country, currentTemp, currentTime, condition, location, tempHigh, tempLow,
          windSpeed, windDirection, precipitation, visibility;

        public Day()
        {
            date = city = country =currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = "";
        }
    }
}
