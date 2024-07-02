using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Weatherwise.Classes;

namespace Weatherwise
{
    public partial class CurrentWeatherControl : UserControl
    {
        WeatherInfo info;
        public WeatherInfo Info { get => info; }
        public CurrentWeatherControl()
        {
            InitializeComponent();
            
        }

        private void CurrentWeatherControl_Load(object sender, EventArgs e)
        {
            InitializeForm();
            
        }
        public void InitializeForm()
        {

            string units;
            if (SettingsClass.TempDegrees==Degrees.C)
            {
                units = "units=metric";
            }
            else if(SettingsClass.TempDegrees == Degrees.F)
            {
                units = "units=imperial";
            }
            else
            {
                units = "units=default";
            }

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={CitiesClass.CurrentCityName}&{units}&appid=77b5a128015397b907c53af6d6c1fa01";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string myResponse;

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                myResponse = streamReader.ReadToEnd();
            }
            info = JsonConvert.DeserializeObject<WeatherInfo>(myResponse);

            if (SettingsClass.Wind==WindSpeed.KM_H)
            {
                info.Wind.Speed *= 1000;
                info.Wind.Speed /= 3600;
            }

            if (SettingsClass.MyPressure == Pressure.MMHG)
            {
                info.Main.Pressure = (float)info.Main.Pressure * 0.75f;
            }

            

            weatherPictureBox.Image = info.Weather[0].Icon.GetWeatherImage();
            descLabel.Text = info.Weather[0].Description;
            degLabel.Text = Math.Round(info.Main.Temp).ToString() + SettingsClass.TempDegrees.GetStrDeg();
            cityNameLabel.Text = info.Name;
            tempGradLabel.Text = $"{Math.Round(info.Main.Temp_max)} {SettingsClass.TempDegrees.GetStrDeg()}/{Math.Round(info.Main.Temp_min)} {SettingsClass.TempDegrees.GetStrDeg()}";
            coordLabel.Text = $"lon: {info.Coord.Lon}, lat: {info.Coord.Lat}";
            windLabel.Text = "Wind: " + Math.Round(info.Wind.Speed) + SettingsClass.Wind.GetStrWindSpeed();
            feelsLikeLabel.Text = "Feels like: " + Math.Round(info.Main.Feels_like) + SettingsClass.TempDegrees.GetStrDeg();
            humidityLabel.Text = "Humidity: " + info.Main.Humidity + "%";
            pressureLabel.Text = "Pressure: " + info.Main.Pressure + $" {SettingsClass.MyPressure.GetStrPressure()}";

            DateTimeOffset time = DateTimeOffset.FromUnixTimeSeconds(info.Sys.Sunrise);

            if (!SettingsClass.UseUtc)
            {
                time = time.ToOffset(info.GetHoursAndMin());
            }

            sunriseLabel.Text = "Sunrise at " + time.Hour + ":" + time.Minute;

            time = DateTimeOffset.FromUnixTimeSeconds(info.Sys.Sunset);
            if (!SettingsClass.UseUtc)
            {
                time = time.ToOffset(info.GetHoursAndMin());
            }

            sunsetLabel.Text = "Sunset at " + time.Hour + ":" + time.Minute;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new HourlyForecastForm(info.Coord.Lon, info.Coord.Lat).Show();
            ParentForm.Hide();
        }
    }
}
