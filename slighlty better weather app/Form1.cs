using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml; 

namespace slighlty_better_weather_app
{
    public partial class Form1 : Form

    {
        public int coolDown;
        public static double currentTemp; 
        public static List<Day> dayForcast = new List<Day>();
        public Form1()
        {
            InitializeComponent();
            ExtractForecast();
     
            ExtractCurrent();
         currentWeather cs = new currentWeather();
         this.Controls.Add(cs);
        }
        
        private void ExtractForecast()
        {
           XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Belfast,GB&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            while (reader.Read())
            {
                Day newDay = new Day();
                reader.ReadToFollowing("time");
                newDay.currentTime = reader.GetAttribute("day");
                
                reader.ReadToFollowing("sun");
                newDay.sunRise = reader.GetAttribute("rise");
                newDay.sunSet = reader.GetAttribute("set");

                reader.ReadToFollowing("symbol");
                //code for what number for symbol to use 
                newDay.weatherTracker = reader.GetAttribute("number");
                // name for the weather in the text box  
                newDay.weather = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                newDay.currentTemp = reader.GetAttribute("day");
                //for min and max code 
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

                if(newDay.date !=null)

                {
                    dayForcast.Add(newDay);
                }

            }

        }
        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Belfast,GB&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            dayForcast[0].location = reader.GetAttribute("name");
           
            reader.ReadToFollowing("country");
            dayForcast[0].country = reader.ReadInnerXml();
         
            reader.ReadToFollowing("temperature");
            dayForcast[0].currentTemp = reader.GetAttribute("value");

            dayForcast[0].celceus = reader.GetAttribute("units");
           
            reader.ReadToFollowing("humidity");
            dayForcast[0].humidity = reader.GetAttribute("value");
          
            reader.ReadToFollowing("lastupdate");
            dayForcast[0].lastupdate = reader.GetAttribute("value");


        }
    
    }
}
