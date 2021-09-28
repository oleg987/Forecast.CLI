using Forecast.Service.Domain;
using Forecast.Service.Services.Base;
using Forecast.Service.Services.Implementation.OpenWeather;
using Forecast.Service.Services.Implementation.OpenWeather.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forecast.UI
{
    public partial class Main : Form
    {
        private IWeatherServiceSettings settings;
        private IWeatherService service;
        private IWeatherQuery query;

        private WeatherForecast currentForecast;

        public Main()
        {
            InitializeComponent();
            settings = new OpenWeatherSettings("c16337ebad8860ce112d59b2d00ff139", @"http://api.openweathermap.org/data/2.5/weather?");
            service = new OpenWeatherService(settings);
            query = new QueryByCityId(698740);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            currentForecast = service.GetForecast(query);
            RefreshData();
        }

        private void RefreshData()
        {
            if (currentForecast is null)
            {
                MessageBox.Show("Error while recieving weather data.");
                return;
            }

            lb_city.Text = currentForecast.City;
            lb_temp.Text = currentForecast.Temperature.ToString();
            lb_pres.Text = currentForecast.Pressure.ToString();
            lb_hum.Text = currentForecast.Humidity.ToString();
            lb_rize.Text = currentForecast.Sunrise.ToString("T");
            lb_set.Text = currentForecast.Sunset.ToString("T");
        }
    }
}
