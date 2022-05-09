using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slighlty_better_weather_app
{
    public class Day
    {
        //string for 
        public string  weatherTracker ,date,lastupdate,humidity,sunRise,sunSet,weather,city,country, currentTemp, currentTime, condition, location, tempHigh, tempLow,
          windSpeed, windDirection, precipitation, visibility,celceus;

        public Day()
        {
           weatherTracker= date=humidity=lastupdate =sunSet=celceus=sunRise=weather= city = country =currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = "";
        }
    }
}
