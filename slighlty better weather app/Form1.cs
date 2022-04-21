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
        public static List<Day> dayForcast = new List<Day>();
        public Form1()
        {
            InitializeComponent();
        //    ExtractForecast();
     
       //     ExtractCurrent();
         currentWeather cs = new currentWeather();
         this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
           XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Belfast,Ire&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            while (reader.Read())
            {
                Day newDay = new Day();

                reader.ReadToFollowing("name");
                newDay.


            }
        }
    }
}
