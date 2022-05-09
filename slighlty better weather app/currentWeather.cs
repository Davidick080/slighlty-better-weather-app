using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slighlty_better_weather_app
{
    public partial class currentWeather : UserControl
    {
    
        public double currentTemp;
      // int for converting Form1.dayForcats[0].weatherTracker to int 
      //left here for when converting weatherTracker to int 
      //  public int weatherNumber;
        public currentWeather()
        {
            InitializeComponent();

            DisplayCurrent();
        }
        public void DisplayCurrent()
        {

        
            //conversion code for currentTemp i.e celcius 
            currentTemp = Convert.ToDouble(Form1.dayForcast[0].currentTemp);
            currentTemp = Math.Round(currentTemp);
            celcius.Text = $"{ currentTemp.ToString()} c";
            //conversion code for weather from string to interger 
            //needed when converting weather.Tracker to weatherNumber
            //weatherNumber = Convert.ToInt32(Form1.dayForcast[0].weatherTracker);
           


            currentDate.Text = Form1.dayForcast[0].currentTime;
            curentWeather.Text = Form1.dayForcast[0].weather;
            city.Text = Form1.dayForcast[0].location;
            country.Text = Form1.dayForcast[0].country;
            min_TextBox.Text = Form1.dayForcast[0].tempLow;
            max_TextBox.Text = Form1.dayForcast[0].tempHigh;
            sunRise_Text.Text = Form1.dayForcast[0].sunRise.Substring(11);
            sunSet_Text.Text = Form1.dayForcast[0].sunSet.Substring(11);
         // if enough time use weatherTracker to show box or weatherBox and show current weather example rain
         // if also enoghh time use weatherTracker to also change screen background to colour to math weather  
            //if (weatherNumber = 200)
            //{

            //}
        }

      
    }
}

